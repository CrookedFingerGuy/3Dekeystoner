using System;
using System.Collections.Generic;
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
    public class UVEditTabPageData
    {
        public Mat rawPhoto;               //Unedited photo
        public Mat finalImage;             //Image after the perspective adjustments and cropping are applied
        public int outputHeight;           //Height of the image after the perspective adjustments
        public int outputWidth;            //Width of the image after the perspective adjustments
        public int outputX;                //X location on the texture after the perspective adjustments are applied
        public int outputY;                //Y location on the texture after the perspective adjustments are applied
        public Point[] uvCorners;          //4 points that mark the edge of the area that will become the texture
        public int activePoint;            //The index in uvCorners of the the currenly selected point
        public Point currentPoint;         //The coordinates of the currently selected point
        public bool dragging;              //Is the mouse currently dragging on the tab
        public bool drawing;               //Is the tab currently computing what to draw/activly drawing
        public string fileName;            //Location of the undeited photo in the file system

        public UVEditTabPageData()
        {
            finalImage = new Mat();
            rawPhoto = new Mat();
            //uvCorners = new Point[4];
            uvCorners = new Point[] {new Point(50, 50),
                                        new Point(50, 350),
                                        new Point(350, 350),
                                        new Point(350, 50),};
            activePoint = -1;
            currentPoint = new Point(0, 0);
            drawing = false;
            dragging = false;
        }

        public Mat handle_DragDrop(object sender,DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filesDroped = (string[])e.Data.GetData(DataFormats.FileDrop);
                string filename = filesDroped[0];
                rawPhoto = new Mat(filename);
                return rawPhoto;
            }
            else
            {
                var toHandle = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                rawPhoto = new Mat(toHandle.Text);
                return  rawPhoto;
            }
        }

        public Mat handle_toolStripButtonClick(string filename)
        {
            rawPhoto = new Mat(filename);
            return rawPhoto;
        }

        public Mat handel_GuessButtonClick()
        {
            Mat workingImage = new Mat();
            Mat contourImage = new Mat();

            CvInvoke.CvtColor(rawPhoto, contourImage, ColorConversion.Bgr2Gray);

            UMat pyrDown = new UMat();
            CvInvoke.PyrDown(contourImage, pyrDown);
            CvInvoke.PyrUp(pyrDown, contourImage);
            CvInvoke.Threshold(contourImage, contourImage, 100, 255, ThresholdType.BinaryInv);

            VectorOfVectorOfPoint contours;

            contours = new VectorOfVectorOfPoint();
            Mat m = new Mat();

            CvInvoke.FindContours(contourImage, contours, m, RetrType.Ccomp, ChainApproxMethod.ChainApproxSimple);


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

            uvCorners = new Point[] {new Point(convexCOI[0].ToArray().ElementAt<Point>(0).X, convexCOI[0].ToArray().ElementAt<Point>(0).Y),
                                        new Point(convexCOI[0].ToArray().ElementAt<Point>(1).X, convexCOI[0].ToArray().ElementAt<Point>(1).Y),
                                        new Point(convexCOI[0].ToArray().ElementAt<Point>(2).X, convexCOI[0].ToArray().ElementAt<Point>(2).Y),
                                        new Point(convexCOI[0].ToArray().ElementAt<Point>(3).X, convexCOI[0].ToArray().ElementAt<Point>(3).Y)};

            Mat pMatrix = new Mat();
            PointF[] temp = new PointF[] { new PointF(2048, 0), new PointF(2048, 2048), new PointF(0, 2048), new PointF(0, 0) };



            if (convexCOI[0].Size >= 4)
            {
                Point[] ctemp = convexCOI[0].ToArray();
                PointF[] coit = new PointF[4];
                for (int i = 0; i < 4; i++)
                {
                    coit[i].X = ctemp[i].X;
                    coit[i].Y = ctemp[i].Y;
                }

                pMatrix = CvInvoke.GetPerspectiveTransform(coit, temp);
                CvInvoke.WarpPerspective(rawPhoto, workingImage, pMatrix, rawPhoto.Size);
            }
            workingImage.CopyTo(finalImage);
            Mat cropped = new Mat(finalImage, new Rectangle(0, 0, 2048, 2048));
            CvInvoke.GetRotationMatrix2D(new Point(cropped.Cols / 2, cropped.Rows / 2), -90, 1, pMatrix);
            CvInvoke.WarpAffine(cropped, cropped, pMatrix, cropped.Size);

            finalImage = cropped;

            return finalImage;
        }

        public void handel_Paint(object sender,PaintEventArgs e,int width, int height)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red);            
            if (uvCorners[0] != null)
            {
                double scaleX = 1;
                double scaleY = 1;
                double transX = 0;
                double transY = 0;
                if (rawPhoto.Height > rawPhoto.Width)//Was FrontMat
                {
                    scaleX = (double)((double)rawPhoto.Size.Height / (double)(height));
                    transX = (double)(((double)width - ((double)rawPhoto.Width / scaleX)) / 2);
                    scaleY = (double)((double)rawPhoto.Size.Height / (double)(height));
                    transY = 0;
                }
                for (int i = 0; i < 4; i++)
                {
                    g.DrawEllipse(pen, (float)((uvCorners[i].X / scaleX) + transX - 2.5), (float)((uvCorners[i].Y / scaleY) + transY - 2.5), 5, 5);
                }
                g.DrawLine(pen, (float)(uvCorners[0].X / scaleX + transX), (float)(uvCorners[0].Y / scaleY), (float)(uvCorners[1].X / scaleX + transX), (float)(uvCorners[1].Y / scaleY));
                g.DrawLine(pen, (float)(uvCorners[1].X / scaleX + transX), (float)(uvCorners[1].Y / scaleY), (float)(uvCorners[2].X / scaleX + transX), (float)(uvCorners[2].Y / scaleY));
                g.DrawLine(pen, (float)(uvCorners[2].X / scaleX + transX), (float)(uvCorners[2].Y / scaleY), (float)(uvCorners[3].X / scaleX + transX), (float)(uvCorners[3].Y / scaleY));
                g.DrawLine(pen, (float)(uvCorners[3].X / scaleX + transX), (float)(uvCorners[3].Y / scaleY), (float)(uvCorners[0].X / scaleX + transX), (float)(uvCorners[0].Y / scaleY));
            }
        }

        public int CheckIfPointClicked(Point toCheck, int width, int height)
        {
            double scaleX = 1;
            double scaleY = 1;
            double transX = 0;
            double transY = 0;
            if (rawPhoto.Height > rawPhoto.Width)
            {
                scaleX = (double)((double)rawPhoto.Size.Height / (double)(height));
                transX = (double)(((double)width - ((double)rawPhoto.Width / scaleX)) / 2);
                scaleY = (double)((double)rawPhoto.Size.Height / (double)(height));
                transY = 0;
            }

            for (int i = 0; i < 4; i++)
            {
                if (((uvCorners[i].X / scaleX + transX - toCheck.X) * (uvCorners[i].X / scaleX + transX - toCheck.X) + (uvCorners[i].Y / scaleY + transY - toCheck.Y) * (uvCorners[i].Y / scaleY + transY - toCheck.Y)) < 25)
                {
                    return i;
                }
            }

            return -1;
        }

        public void DistortPreviewImage()
        {
            Mat workingImage = rawPhoto;

            Mat pMatrix = new Mat();
            PointF[] temp = new PointF[] { new PointF(2048, 0), new PointF(2048, 2048), new PointF(0, 2048), new PointF(0, 0) };

            Mat finalImage = new Mat();


            Point[] ctemp = uvCorners;
            PointF[] coit = new PointF[4];
            for (int i = 0; i < 4; i++)
            {
                coit[i].X = ctemp[i].X;
                coit[i].Y = ctemp[i].Y;
            }

            pMatrix = CvInvoke.GetPerspectiveTransform(coit, temp);
            CvInvoke.WarpPerspective(workingImage, finalImage, pMatrix, workingImage.Size);

            Mat cropped = new Mat(finalImage, new Rectangle(0, 0, 2048, 2048));
            CvInvoke.GetRotationMatrix2D(new Point(cropped.Cols / 2, cropped.Rows / 2), -90, 1, pMatrix);
            CvInvoke.WarpAffine(cropped, cropped, pMatrix, cropped.Size);

            Program.mForm.PreviewImage.Image=cropped;
            Program.mForm.PreviewImage.Invalidate();
        }


        public void handle_MouseDown(object sender,MouseEventArgs e,int width, int height)
        {
            if (e.Button != MouseButtons.Left) return;


            double scaleX = 1;
            double scaleY = 1;
            double transX = 0;
            double transY = 0;
            if (rawPhoto?.Height > rawPhoto?.Width)
            {
                scaleX = (double)((double)rawPhoto.Size.Height / (double)(height));
                transX = (double)(((double)width - ((double)rawPhoto.Width / scaleX)) / 2);
                scaleY = (double)((double)rawPhoto.Size.Height / (double)(height));
                transY = 0;
            }

            drawing = false;
            dragging = false;
            activePoint = CheckIfPointClicked(e.Location,width,height);
            if (activePoint != -1)
            {
                dragging = true;
                currentPoint = new Point((int)((e.Location.X - transX) * transX), (int)((e.Location.Y - transY) * transY));
                uvCorners[activePoint].X = (int)((e.Location.X - transX) * scaleX);
                uvCorners[activePoint].Y = (int)((e.Location.Y - transY) * scaleY);
                if (!drawing)
                {
                    drawing = true;
                    DistortPreviewImage();
                    Program.mForm.tabControlSides.SelectedTab.Refresh();
                    GC.Collect();
                    drawing = false;
                }
            }
        }

        public void handle_MouseMove(object sender, MouseEventArgs e, int width, int height)
        {
            double scaleX = 1;
            double scaleY = 1;
            double transX = 0;
            double transY = 0;
            if (rawPhoto?.Height > rawPhoto?.Width)
            {
                scaleX = (double)((double)rawPhoto.Size.Height / (double)(height));
                transX = (double)(((double)width - ((double)rawPhoto.Width / scaleX)) / 2);
                scaleY = (double)((double)rawPhoto.Size.Height / (double)(height));
                transY = 0;
            }
            if (dragging)
            {
                currentPoint = e.Location;
                uvCorners[activePoint].X = (int)((e.Location.X - transX) * scaleX);
                uvCorners[activePoint].Y = (int)((e.Location.Y - transY) * scaleY);
                if (!drawing)
                {
                    drawing = true;
                    DistortPreviewImage();
                    Program.mForm.tabControlSides.SelectedTab.Refresh();
                    GC.Collect();
                    drawing = false;
                }
            }
        }

        public void handle_MouseUp(object sender, MouseEventArgs e, int width, int height)
        {
            double scaleX = 1;
            double scaleY = 1;
            double transX = 0;
            double transY = 0;
            if (rawPhoto?.Height > rawPhoto?.Width)
            {
                scaleX = (double)((double)rawPhoto.Size.Height / (double)(height));
                transX = (double)(((double)width - ((double)rawPhoto.Width / scaleX)) / 2);
                scaleY = (double)((double)rawPhoto.Size.Height / (double)(height));
                transY = 0;
            }
            if (dragging)
            {
                uvCorners[activePoint].X = (int)((e.Location.X - transX) * scaleX);
                uvCorners[activePoint].Y = (int)((e.Location.Y - transY) * scaleY);
                if (!drawing)
                {
                    drawing = true;
                    DistortPreviewImage();
                    Program.mForm.tabControlSides.SelectedTab.Refresh();
                    GC.Collect();
                    drawing = false;
                }
            }
            dragging = false;
            activePoint = -1;
        }
    }
}
