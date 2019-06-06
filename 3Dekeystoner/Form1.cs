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

            LineSegment2D[] lines = CvInvoke.HoughLinesP(cannyEdges, 1, Math.PI / 45.0, 30, 50, 150);




            finalImageBox.Image = img;


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

            Mat lineImage = img;
            Mat lineImage2 = new Mat();
            perspMat= CvInvoke.GetPerspectiveTransform(
                new PointF[] { new PointF { X = boxEdges[0].P1.X, Y =boxEdges[0].P1.Y }, new PointF { X = boxEdges[2].P1.X, Y = boxEdges[2].P1.Y },
                new PointF {X = boxEdges[3].P1.X, Y =boxEdges[3].P1.Y }, new PointF {X = boxEdges[1].P1.X, Y =boxEdges[1].P1.Y } }, 
                new PointF[] { new PointF { X = 0, Y = 0 }, new PointF { X = 2048, Y = 0 }, new PointF { X = 0, Y = 2048 }, new PointF { X = 2048, Y = 2048 } });
            CvInvoke.WarpPerspective(lineImage,lineImage2, perspMat, lineImage.Size);
            Mat croped = new Mat(lineImage2, new Rectangle(0, 0, 2048, 2048));
            CvInvoke.GetRotationMatrix2D(new Point(croped.Cols / 2, croped.Rows / 2), -90, 1, matrixMcMatrix);            
            CvInvoke.WarpAffine(croped, croped, matrixMcMatrix, lineImage.Size);
            finalImageBox.Image = croped;



            lineImage.SetTo(new MCvScalar(0.0));
            foreach (LineSegment2D line in lines)
                CvInvoke.Line(lineImage, line.P1, line.P2,new MCvScalar(0,255,0), 2);
            foreach (LineSegment2D line in boxEdges)
                CvInvoke.Line(lineImage, line.P1, line.P2, new MCvScalar(0, 0, 255), 2);
            lineImageBox.Image = lineImage;
        }
    }
}
