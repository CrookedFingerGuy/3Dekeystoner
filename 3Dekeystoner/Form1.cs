﻿using System;
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
            StringBuilder msgBuilder = new StringBuilder("Performance: ");

            //Load the image from file and resize it for display
            Image<Bgr, Byte> img =
               new Image<Bgr, byte>("C:\\Users\\Chiz\\Documents\\3D Projects\\Wizardry 8\\Front.jpg");
            //.Resize(2048, 2048, Emgu.CV.CvEnum.Inter.Linear, true);

            //Convert the image to grayscale and filter out the noise
            UMat uimage = new UMat();
            CvInvoke.CvtColor(img, uimage, ColorConversion.Bgr2Gray);

            //use image pyr to remove noise
            UMat pyrDown = new UMat();
            CvInvoke.PyrDown(uimage, pyrDown);
            CvInvoke.PyrUp(pyrDown, uimage);

            //Image<Gray, Byte> gray = img.Convert<Gray, Byte>().PyrDown().PyrUp();


            #region Canny and edge detection
            Stopwatch watch = Stopwatch.StartNew();
            double cannyThreshold = 180.0;
            double cannyThresholdLinking = 10.0;
            UMat cannyEdges = new UMat();
            CvInvoke.Canny(uimage, cannyEdges, cannyThreshold, cannyThresholdLinking);

            LineSegment2D[] lines = CvInvoke.HoughLinesP(
               cannyEdges,
               1, //Distance resolution in pixel-related units
               Math.PI / 45.0, //Angle resolution measured in radians.
               30, //threshold
               50, //min Line width
               150); //gap between lines

            watch.Stop();
            msgBuilder.Append(String.Format("Canny & Hough lines - {0} ms; {1} Lines", watch.ElapsedMilliseconds, lines.Length));
            #endregion



            triangleRectangleImageBox.Image = img;
            this.Text = msgBuilder.ToString();


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

            Image<Bgr, Byte> lineImage = img;
            Mat lineImage2 = new Mat();
            perspMat= CvInvoke.GetPerspectiveTransform(
                new PointF[] { new PointF { X = boxEdges[0].P1.X, Y =boxEdges[0].P1.Y }, new PointF { X = boxEdges[2].P1.X, Y = boxEdges[2].P1.Y },
                new PointF {X = boxEdges[3].P1.X, Y =boxEdges[3].P1.Y }, new PointF {X = boxEdges[1].P1.X, Y =boxEdges[1].P1.Y } }, 
                new PointF[] { new PointF { X = 0, Y = 0 }, new PointF { X = 2048, Y = 0 }, new PointF { X = 0, Y = 2048 }, new PointF { X = 2048, Y = 2048 } });
            CvInvoke.WarpPerspective(lineImage,lineImage2, perspMat, lineImage.Size);
            Mat croped = new Mat(lineImage2, new Rectangle(0, 0, 2048, 2048));
            CvInvoke.GetRotationMatrix2D(new Point(croped.Cols / 2, croped.Rows / 2), -90, 1, matrixMcMatrix);            
            CvInvoke.WarpAffine(croped, croped, matrixMcMatrix, lineImage.Size);
            triangleRectangleImageBox.Image = croped;
                


            #region draw lines
            lineImage = img.CopyBlank();
            foreach (LineSegment2D line in lines)
                lineImage.Draw(line, new Bgr(Color.Green), 2);
            foreach (LineSegment2D line in boxEdges)
                lineImage.Draw(line, new Bgr(Color.Red), 2);
            lineImageBox.Image = lineImage;
            #endregion
        }
    }
}