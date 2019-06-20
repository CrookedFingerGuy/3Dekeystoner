using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace _3Dekeystoner
{
    public partial class MainBoxTextureEditForm : Form
    {
        Mat FrontMat;
        Mat FrontMatFinal;
        Point[][] uvCorners;
        int activePoint;
        Point currentPoint;
        bool dragging;
        bool drawing;

        public MainBoxTextureEditForm()
        {
            InitializeComponent();
            imageBoxFront.AllowDrop = true;
            listView1.AllowDrop = true;
            listView1.MultiSelect = false;
            FrontMatFinal = new Mat();
            uvCorners = new Point[6][];
            activePoint = -1;
            currentPoint = new Point(0, 0);
            drawing = false;
            dragging = false;
        }

        private void openFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openJPG = new OpenFileDialog();
            openJPG.Multiselect = true;
            if (openJPG.ShowDialog() == DialogResult.OK)
            {
                foreach(string file in openJPG.FileNames)
                {
                    //parsedFileName = Path.GetFileName(file);
                    imageList1.Images.Add(file,Image.FromFile(file));
                    listView1.Items.Add(file, imageList1.Images.IndexOfKey(file));
                }
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imageBoxFront_DragDrop(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filesDroped = (string[])e.Data.GetData(DataFormats.FileDrop);
                string filename = filesDroped[0];
                FrontMat = new Mat(filename);
                imageBoxFront.Image = FrontMat;
            }
            else
            {
                var toHandle = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                FrontMat = new Mat(toHandle.Text);
                imageBoxFront.Image = FrontMat;
            }
        }

        private void imageBoxFront_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                FrontMat = new Mat(listView1.SelectedItems[0].Text);
                imageBoxFront.Image = FrontMat;
            }
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(listView1.SelectedItems[0], DragDropEffects.Copy);
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            Mat workingImage= new Mat();
            switch(tabControlSides.SelectedIndex)
            {
                case 0:
                    {
                        workingImage=(Mat)imageBoxFront.Image;
                    }break;
            }


            Mat finalImage = new Mat();
            CvInvoke.CvtColor(workingImage, finalImage, ColorConversion.Bgr2Gray);

            UMat pyrDown = new UMat();
            CvInvoke.PyrDown(finalImage, pyrDown);
            CvInvoke.PyrUp(pyrDown, finalImage);
            CvInvoke.Threshold(finalImage, finalImage, 100, 255, ThresholdType.BinaryInv);

            VectorOfVectorOfPoint contours;
            Mat contourImage = new Mat();

            contours = new VectorOfVectorOfPoint();
            Mat m = new Mat();

            CvInvoke.FindContours(finalImage, contours, m, RetrType.Ccomp, ChainApproxMethod.ChainApproxSimple);


            double largestArea = 0.0;
            double tempArea = 0.0;
            int largestContourIndex = 0;

            for (int i = 0; i < contours.Size; i++)
            {
                tempArea = CvInvoke.ContourArea(contours[i]);
                if (tempArea > largestArea)
                {
                    largestArea = tempArea;
                    largestContourIndex = i;
                }
            }


            VectorOfVectorOfPoint convexCOI = new VectorOfVectorOfPoint(1);
            CvInvoke.ConvexHull(contours[largestContourIndex], convexCOI[0]);
            CvInvoke.ApproxPolyDP(convexCOI[0], convexCOI[0], 100, true);

            uvCorners[0] = new Point[] {new Point(convexCOI[0].ToArray().ElementAt<Point>(0).X, convexCOI[0].ToArray().ElementAt<Point>(0).Y),
                                        new Point(convexCOI[0].ToArray().ElementAt<Point>(1).X, convexCOI[0].ToArray().ElementAt<Point>(1).Y),
                                        new Point(convexCOI[0].ToArray().ElementAt<Point>(2).X, convexCOI[0].ToArray().ElementAt<Point>(2).Y),
                                        new Point(convexCOI[0].ToArray().ElementAt<Point>(3).X, convexCOI[0].ToArray().ElementAt<Point>(3).Y)};

            Mat pMatrix = new Mat();
            PointF[] temp = new PointF[] { new PointF(2048, 0), new PointF(2048, 2048), new PointF(0, 2048), new PointF(0, 0) };



            if (convexCOI[0].Size == 4)
            {
                Point[] ctemp = convexCOI[0].ToArray();
                PointF[] coit = new PointF[4];
                for (int i = 0; i < 4; i++)
                {
                    coit[i].X = ctemp[i].X;
                    coit[i].Y = ctemp[i].Y;
                }

                pMatrix = CvInvoke.GetPerspectiveTransform(coit, temp);
                CvInvoke.WarpPerspective(workingImage, finalImage, pMatrix, workingImage.Size);
            }

            Mat croped = new Mat(finalImage, new Rectangle(0, 0, 2048, 2048));
            CvInvoke.GetRotationMatrix2D(new Point(croped.Cols / 2, croped.Rows / 2), -90, 1, pMatrix);
            CvInvoke.WarpAffine(croped, croped, pMatrix, croped.Size);

            PreviewImage.Image = croped;

            switch (tabControlSides.SelectedIndex)
            {
                case 0:
                    {
                        FrontMatFinal.CopyTo(croped);
                    }
                    break;
            }
            imageBoxFront.Invalidate();
        }

        public void DistortPreviewImage()
        {
            Mat workingImage = new Mat();
            switch (tabControlSides.SelectedIndex)
            {
                case 0:
                    {
                        workingImage = (Mat)imageBoxFront.Image;
                    }
                    break;
            }

            Mat pMatrix = new Mat();
            PointF[] temp = new PointF[] { new PointF(2048, 0), new PointF(2048, 2048), new PointF(0, 2048), new PointF(0, 0) };

            Mat finalImage = new Mat();


                Point[] ctemp = uvCorners[0];
                PointF[] coit = new PointF[4];
                for (int i = 0; i < 4; i++)
                {
                    coit[i].X = ctemp[i].X;
                    coit[i].Y = ctemp[i].Y;
                }

                pMatrix = CvInvoke.GetPerspectiveTransform(coit, temp);
                CvInvoke.WarpPerspective(workingImage, finalImage, pMatrix, workingImage.Size);

            Mat croped = new Mat(finalImage, new Rectangle(0, 0, 2048, 2048));
            CvInvoke.GetRotationMatrix2D(new Point(croped.Cols / 2, croped.Rows / 2), -90, 1, pMatrix);
            CvInvoke.WarpAffine(croped, croped, pMatrix, croped.Size);

            PreviewImage.Image = croped;
            PreviewImage.Invalidate();
        }


        private void PreviewImage_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void imageBoxRight_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red);
            g.DrawEllipse(pen, 10, 10, 20, 20);
        }

        private void imageBoxFront_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red);
            //g.DrawLine(pen,0, 0, 655, 566);
            if (uvCorners[0]?[0]!=null)
            {
                double scaleX=1;
                double scaleY=1;
                double transX = 0;
                double transY = 0;
                if (FrontMat.Height > FrontMat.Width)
                {
                    scaleX= (double)((double)FrontMat.Size.Height / (double)(imageBoxFront.Height));
                    transX = (double)(((double)imageBoxFront.Width - ((double)FrontMat.Width/scaleX))/ 2);
                    scaleY = (double)((double)FrontMat.Size.Height / (double)(imageBoxFront.Height));
                    transY = 0;
                }
                for (int i = 0; i < 4; i++)
                {
                    g.DrawEllipse(pen, (float)((uvCorners[0][i].X / scaleX) + transX - 2.5), (float)((uvCorners[0][i].Y / scaleY) + transY - 2.5), 5, 5);
                }
                g.DrawLine(pen, (float)(uvCorners[0][0].X / scaleX + transX), (float)(uvCorners[0][0].Y / scaleY), (float)(uvCorners[0][1].X / scaleX + transX), (float)(uvCorners[0][1].Y / scaleY));
                g.DrawLine(pen, (float)(uvCorners[0][1].X / scaleX + transX), (float)(uvCorners[0][1].Y / scaleY), (float)(uvCorners[0][2].X / scaleX + transX), (float)(uvCorners[0][2].Y / scaleY));
                g.DrawLine(pen, (float)(uvCorners[0][2].X / scaleX + transX), (float)(uvCorners[0][2].Y / scaleY), (float)(uvCorners[0][3].X / scaleX + transX), (float)(uvCorners[0][3].Y / scaleY));
                g.DrawLine(pen, (float)(uvCorners[0][3].X / scaleX + transX), (float)(uvCorners[0][3].Y / scaleY), (float)(uvCorners[0][0].X / scaleX + transX), (float)(uvCorners[0][0].Y / scaleY));
            }
        }

        private int CheckIfPointClicked(Point toCheck)
        {
            double scaleX = 1;
            double scaleY = 1;
            double transX = 0;
            double transY = 0;
            if (FrontMat.Height > FrontMat.Width)
            {
                scaleX = (double)((double)FrontMat.Size.Height / (double)(imageBoxFront.Height));
                transX = (double)(((double)imageBoxFront.Width - ((double)FrontMat.Width / scaleX)) / 2);
                scaleY = (double)((double)FrontMat.Size.Height / (double)(imageBoxFront.Height));
                transY = 0;
            }

            for (int i=0;i<4;i++)
            {
                if(((uvCorners[0][i].X/scaleX+transX-toCheck.X)*(uvCorners[0][i].X / scaleX + transX - toCheck.X)+(uvCorners[0][i].Y / scaleY + transY - toCheck.Y)*(uvCorners[0][i].Y / scaleY + transY - toCheck.Y))<25)
                {
                    return i;
                }
            }

            return -1;
        }

        private void imageBoxFront_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;


            double scaleX = 1;
            double scaleY = 1;
            double transX = 0;
            double transY = 0;
            if (FrontMat?.Height > FrontMat?.Width)
            {
                scaleX = (double)((double)FrontMat.Size.Height / (double)(imageBoxFront.Height));
                transX = (double)(((double)imageBoxFront.Width - ((double)FrontMat.Width / scaleX)) / 2);
                scaleY = (double)((double)FrontMat.Size.Height / (double)(imageBoxFront.Height));
                transY = 0;
            }

            drawing = false;
            dragging = false;
            activePoint = CheckIfPointClicked(e.Location);
            if(activePoint != -1 )
            {
                dragging = true;
                currentPoint = new Point((int)((e.Location.X-transX)*transX), (int)((e.Location.Y-transY)*transY));
                uvCorners[0][activePoint].X = (int)((e.Location.X - transX) * scaleX);
                uvCorners[0][activePoint].Y = (int)((e.Location.Y - transY) * scaleY);
                if (!drawing)
                {
                    drawing = true;
                    DistortPreviewImage();
                    imageBoxFront.Invalidate();
                    GC.Collect();
                    drawing = false;
                }
            }
        }

        private void imageBoxFront_MouseMove(object sender, MouseEventArgs e)
        {
            double scaleX = 1;
            double scaleY = 1;
            double transX = 0;
            double transY = 0;
            if (FrontMat?.Height > FrontMat?.Width)
            {
                scaleX = (double)((double)FrontMat.Size.Height / (double)(imageBoxFront.Height));
                transX = (double)(((double)imageBoxFront.Width - ((double)FrontMat.Width / scaleX)) / 2);
                scaleY = (double)((double)FrontMat.Size.Height / (double)(imageBoxFront.Height));
                transY = 0;
            }
            if (dragging)
            {
                currentPoint = e.Location;
                uvCorners[0][activePoint].X = (int)((e.Location.X - transX) * scaleX);
                uvCorners[0][activePoint].Y = (int)((e.Location.Y - transY) * scaleY);
                if (!drawing)
                {
                    drawing = true;
                    DistortPreviewImage();
                    imageBoxFront.Invalidate();
                    GC.Collect();
                    drawing = false;
                }
            }
        }

        private void imageBoxFront_MouseUp(object sender, MouseEventArgs e)
        {
            double scaleX = 1;
            double scaleY = 1;
            double transX = 0;
            double transY = 0;
            if (FrontMat?.Height > FrontMat?.Width)
            {
                scaleX = (double)((double)FrontMat.Size.Height / (double)(imageBoxFront.Height));
                transX = (double)(((double)imageBoxFront.Width - ((double)FrontMat.Width / scaleX)) / 2);
                scaleY = (double)((double)FrontMat.Size.Height / (double)(imageBoxFront.Height));
                transY = 0;
            }
            if (dragging)
            {
                uvCorners[0][activePoint].X = (int)((e.Location.X - transX) * scaleX);
                uvCorners[0][activePoint].Y = (int)((e.Location.Y - transY) * scaleY);
                if (!drawing)
                {
                    drawing = true;
                    DistortPreviewImage();
                    imageBoxFront.Invalidate();
                    GC.Collect();
                    drawing = false;
                }
            }
            dragging = false;
            activePoint = -1;
        }

        private void cVStepsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebugForm df= new DebugForm();
            df.Show();
        }
    }
}
