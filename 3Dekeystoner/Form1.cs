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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Mat img =new Mat("C:\\Users\\Chiz\\Documents\\3D Projects\\Wizardry 8\\Front.jpg");
            UMat uimage = new UMat();
            CvInvoke.CvtColor(img, uimage, ColorConversion.Bgr2Gray);

            UMat pyrDown = new UMat();
            CvInvoke.PyrDown(uimage, pyrDown);
            CvInvoke.PyrUp(pyrDown, uimage);

            double cannyThreshold = 180.0;
            double cannyThresholdLinking = 10.0;
            UMat cannyEdges = new UMat();

            CvInvoke.Canny(uimage, cannyEdges, cannyThreshold, cannyThresholdLinking);

            VectorOfVectorOfPoint contours=new VectorOfVectorOfPoint();
            Mat m = new Mat();
            CvInvoke.FindContours(cannyEdges, contours, m, RetrType.External,ChainApproxMethod.ChainApproxSimple);
            finalImageBox.Image = img;


            Mat lineImage = new Mat();
            img.CopyTo(lineImage);
            lineImage.SetTo(new MCvScalar(0.0));
            for (int i = 0; i < contours.Size; i++)
            {
               CvInvoke.DrawContours(lineImage, contours, i, new MCvScalar(255, 0, 0), 2);
            }
            lineImageBox.Image = lineImage;
            /*
            LineSegment2D[] boxEdges = { new LineSegment2D(new Point(0, 0), new Point(0, 0)), new LineSegment2D(new Point(img.Size.Width, 0), new Point(0, 0)), new LineSegment2D(new Point(0, 0), new Point(0, 0)), new LineSegment2D(new Point(0, img.Size.Height), new Point(0, 0)) };

            foreach (LineSegment2D line in lines)
            {
                if (line.P1.X > boxEdges[0].P1.X)
                {
                    boxEdges[0].P1 = line.P1;
                }

                if (line.P2.X > boxEdges[0].P1.X)
                {
                    boxEdges[0].P1 = line.P2;
                }

                if (line.P1.X < boxEdges[1].P1.X)
                {
                    boxEdges[1].P1 = line.P1;
                }

                if (line.P2.X < boxEdges[1].P1.X)
                {
                    boxEdges[1].P1 = line.P2;
                }

                if (line.P1.Y > boxEdges[2].P1.Y)
                {
                    boxEdges[2].P1 = line.P1;
                }

                if (line.P2.Y > boxEdges[2].P1.Y)
                {
                    boxEdges[2].P1 = line.P2;
                }

                if (line.P1.Y < boxEdges[3].P1.Y)
                {
                    boxEdges[3].P1 = line.P1;
                }

                if (line.P2.Y < boxEdges[3].P1.Y)
                {
                    boxEdges[3].P1 = line.P2;
                }
            }

            boxEdges[0].P2 = boxEdges[2].P1;
            boxEdges[1].P2 = boxEdges[3].P1;
            boxEdges[2].P2 = boxEdges[1].P1;
            boxEdges[3].P2 = boxEdges[0].P1;
            

            Mat matrixMcMatrix = new Mat();
            Mat perspMat = new Mat();

            
            Mat lineImage2 = new Mat();
            perspMat= CvInvoke.GetPerspectiveTransform(
                new PointF[] { new PointF { X = boxEdges[0].P1.X, Y =boxEdges[0].P1.Y }, new PointF { X = boxEdges[2].P1.X, Y = boxEdges[2].P1.Y },
                new PointF {X = boxEdges[3].P1.X, Y =boxEdges[3].P1.Y }, new PointF {X = boxEdges[1].P1.X, Y =boxEdges[1].P1.Y } }, 
                new PointF[] { new PointF { X = 0, Y = 0 }, new PointF { X = 2048, Y = 0 }, new PointF { X = 0, Y = 2048 }, new PointF { X = 2048, Y = 2048 } });
            CvInvoke.WarpPerspective(lineImage,lineImage2, perspMat, lineImage.Size);
            */
            Mat matrixMcMatrix = new Mat();
            Mat lineImage2 = lineImage;
            //Mat croped = new Mat(lineImage2, new Rectangle(0, 0, 2048, 2048));
            CvInvoke.GetRotationMatrix2D(new Point(lineImage2.Cols / 2, lineImage2.Rows / 2), -90, 1, matrixMcMatrix);            
            CvInvoke.WarpAffine(lineImage2, lineImage2, matrixMcMatrix, lineImage.Size);
            finalImageBox.Image = lineImage2;
            



            //foreach (LineSegment2D line in boxEdges)
            //  CvInvoke.Line(lineImage, line.P1, line.P2, new MCvScalar(0, 0, 255), 2);
        }
    }
}
