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
        public Mat lineImage;
        public VectorOfVectorOfPoint contours;
        public int contourCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Mat img =new Mat("C:\\Users\\Chiz\\Documents\\3D Projects\\Wizardry 8\\Left.jpg");
            UMat uimage = new UMat();
            CvInvoke.CvtColor(img, img, ColorConversion.Bgr2Gray);
            
            UMat pyrDown = new UMat();
            CvInvoke.PyrDown(img, pyrDown);
            CvInvoke.PyrUp(pyrDown, img);
            CvInvoke.Threshold(img, img, 100, 255, ThresholdType.BinaryInv);


            /*
            double cannyThreshold = 125;
            double cannyThresholdLinking = 255;
            UMat cannyEdges = new UMat();
            //CvInvoke.Canny(img, img, cannyThreshold, cannyThresholdLinking);
            */

            contours =new VectorOfVectorOfPoint();
            Mat m = new Mat();
            CvInvoke.FindContours(img, contours, m, RetrType.Ccomp,ChainApproxMethod.ChainApproxSimple);
            finalImageBox.Image = img;

            this.Text = contours.Size.ToString();

            lineImage = new Mat();
            img.CopyTo(lineImage);
            lineImage.SetTo(new MCvScalar(255.0));
            //CvInvoke.DrawContours(lineImage, contours, -1, new MCvScalar(0.0), 2);

            double largestArea = 0.0;
            double tempArea = 0.0;
            int largestContourIndex = 0;

            for(int i=0;i<contours.Size;i++)
            {
                tempArea= CvInvoke.ContourArea(contours[i]);
                if(tempArea>largestArea)
                {
                    largestArea = tempArea;
                    largestContourIndex = i;
                }
            }

            CvInvoke.DrawContours(lineImage, contours, largestContourIndex, new MCvScalar(0.0), 2);
            lineImageBox.Image = lineImage;
            Mat matrixMcMatrix = new Mat();
            Mat lineImage2 = lineImage;
            //Mat croped = new Mat(lineImage2, new Rectangle(0, 0, 2048, 2048));
            //CvInvoke.GetRotationMatrix2D(new Point(lineImage2.Cols / 2, lineImage2.Rows / 2), -90, 1, matrixMcMatrix);            
            //CvInvoke.WarpAffine(lineImage2, lineImage2, matrixMcMatrix, lineImage.Size);                      
            //foreach (LineSegment2D line in boxEdges)
            //  CvInvoke.Line(lineImage, line.P1, line.P2, new MCvScalar(0, 0, 255), 2);
        }

        private void lineImageBox_Click(object sender, EventArgs e)
        {
        }

        private void nextContourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineImage.SetTo(new MCvScalar(0.0));
            CvInvoke.DrawContours(lineImage, contours, contourCount, new MCvScalar(255, 0, 0), 2);

            lineImageBox.Image = lineImage;
        }
    }
}
