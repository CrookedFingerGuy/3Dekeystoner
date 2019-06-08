using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class DebugForm : Form
    {
        public Mat colorImage;
        public Mat thresholdImage;
        public Mat contourImage;
        public Mat bigContourImage;
        public Mat polyAproxImage;
        public Mat finalImage;
        public VectorOfVectorOfPoint contours;
        public int contourCount;

        public DebugForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Mat colorImage = new Mat("C:\\Users\\Chiz\\Documents\\3D Projects\\Wizardry 8\\Front.jpg");
            Mat img = new Mat();
            CvInvoke.CvtColor(colorImage, img, ColorConversion.Bgr2Gray);

            UMat pyrDown = new UMat();
            CvInvoke.PyrDown(img, pyrDown);
            CvInvoke.PyrUp(pyrDown, img);
            CvInvoke.Threshold(img, img, 100, 255, ThresholdType.BinaryInv);



            contours = new VectorOfVectorOfPoint();
            Mat m = new Mat();
            CvInvoke.FindContours(img, contours, m, RetrType.Ccomp, ChainApproxMethod.ChainApproxSimple);
            //finalImageBox.Image = img;

            this.Text = contours.Size.ToString();

            lineImage = new Mat();
            img.CopyTo(lineImage);
            lineImage.SetTo(new MCvScalar(255.0));
            //CvInvoke.DrawContours(lineImage, contours, -1, new MCvScalar(0.0), 2);

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

            //CvInvoke.DrawContours(lineImage, contours, largestContourIndex, new MCvScalar(0.0), 2);
            VectorOfVectorOfPoint convexCOI = new VectorOfVectorOfPoint(1);
            CvInvoke.ConvexHull(contours[largestContourIndex], convexCOI[0]);
            CvInvoke.ApproxPolyDP(convexCOI[0], convexCOI[0], 100, true);
            CvInvoke.DrawContours(lineImage, convexCOI, 0, new MCvScalar(0.0), 3);

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
                CvInvoke.WarpPerspective(colorImage, colorImage, pMatrix, colorImage.Size);
            }

            Mat croped = new Mat(colorImage, new Rectangle(0, 0, 2048, 2048));
            CvInvoke.GetRotationMatrix2D(new Point(croped.Cols / 2, croped.Rows / 2), -90, 1, pMatrix);
            CvInvoke.WarpAffine(croped, croped, pMatrix, croped.Size);


            lineImageBox.Image = lineImage;            
            finalImageBox.Image = croped;

            this.Text = convexCOI[0].Size.ToString();
            */
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openJPG = new OpenFileDialog();
            if(openJPG.ShowDialog()==DialogResult.OK)
            {
                colorImage = new Mat(openJPG.FileName);
            }

            toolStripStatusLabel1.Text = openJPG.FileName;

            imageBox1.Image = colorImage;
            thresholdImage = new Mat();
            
            
            CvInvoke.CvtColor(colorImage, thresholdImage, ColorConversion.Bgr2Gray);

            UMat pyrDown = new UMat();
            CvInvoke.PyrDown(thresholdImage, pyrDown);
            CvInvoke.PyrUp(pyrDown, thresholdImage);
            CvInvoke.Threshold(thresholdImage, thresholdImage, 100, 255, ThresholdType.BinaryInv);

            imageBox2.Image = thresholdImage;
            
            contours = new VectorOfVectorOfPoint();
            Mat m = new Mat();
            contourImage = new Mat();
            colorImage.CopyTo(contourImage);
            contourImage.SetTo(new MCvScalar(0.0));

            CvInvoke.FindContours(thresholdImage, contours, m, RetrType.Ccomp, ChainApproxMethod.ChainApproxSimple);
            CvInvoke.DrawContours(contourImage, contours, -1, new MCvScalar(255.0,0.0,0.0), 2);

            imageBox3.Image = contourImage;
            
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

            bigContourImage = new Mat();
            contourImage.CopyTo(bigContourImage);
            bigContourImage.SetTo(new MCvScalar(0.0));
            CvInvoke.DrawContours(bigContourImage, contours, largestContourIndex, new MCvScalar(255.0), 2);

            imageBox4.Image = bigContourImage;


            polyAproxImage = new Mat();
            bigContourImage.CopyTo(polyAproxImage);
            polyAproxImage.SetTo(new MCvScalar(255.0,255.0,255.0));

            VectorOfVectorOfPoint convexCOI = new VectorOfVectorOfPoint(1);
            CvInvoke.ConvexHull(contours[largestContourIndex], convexCOI[0]);
            CvInvoke.ApproxPolyDP(convexCOI[0], convexCOI[0], 100, true);
            CvInvoke.DrawContours(polyAproxImage, convexCOI, 0, new MCvScalar(0.0), 3);

            imageBox5.Image = polyAproxImage;

            Mat pMatrix = new Mat();
            PointF[] temp = new PointF[] { new PointF(2048, 0), new PointF(2048, 2048), new PointF(0, 2048), new PointF(0, 0) };
            finalImage = new Mat();
            colorImage.CopyTo(finalImage);


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
                CvInvoke.WarpPerspective(finalImage, finalImage, pMatrix, colorImage.Size);
            }

            Mat croped = new Mat(finalImage, new Rectangle(0, 0, 2048, 2048));
            CvInvoke.GetRotationMatrix2D(new Point(croped.Cols / 2, croped.Rows / 2), -90, 1, pMatrix);
            CvInvoke.WarpAffine(croped, croped, pMatrix, croped.Size);

            imageBox6.Image = croped;
        }
    }
}
