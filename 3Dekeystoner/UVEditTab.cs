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
    public enum BoxTextureFile { BOXFRONT,BOXBACK,BOXSIDES,BOXFLAPLEFT,BOXFLAPRIGHT}
    public class UVEditTabPageData
    {
        public Mat rawPhoto;               //Unedited photo
        public Mat finalImage;             //Image after the perspective adjustments and cropping are applied
        public int outputWidth;            //Width of the image after the perspective adjustments
        public int outputHeight;           //Height of the image after the perspective adjustments
        public int outputX;                //X location on the texture after the perspective adjustments are applied
        public int outputY;                //Y location on the texture after the perspective adjustments are applied
        public Point[] uvCorners;          //4 points that mark the edge of the area that will become the texture
        public PointF[] mappedCorners;     //4 points that are the locations of the texture corners in the guide images
        public int activePoint;            //The index in uvCorners of the the currenly selected point
        public Point currentPoint;         //The coordinates of the currently selected point
        public bool dragging;              //Is the mouse currently dragging on the tab
        public bool drawing;               //Is the tab currently computing what to draw/activly drawing
        public string fileName;            //Location of the undeited photo in the file system
        public BoxTextureFile btf;         //Enum defined above. Keeps track of which 3d preview background image to show
        public double scaleX;              //keeps track of the difference between the width of the image file and the screen size
        public double scaleY;              //keeps track of the difference between the height of the image file and the screen size
        public double transX;              //keeps track of the screen offset on the x axis
        public double transY;              //keeps track of the screen offset on the y axis



        public UVEditTabPageData(int tabIndex)
        {
            finalImage = new Mat();
            rawPhoto = new Mat();
            //Arbitrary starting point for the uv mapping corners
            uvCorners = new Point[] {new Point(50, 50),
                                        new Point(50, 350),
                                        new Point(350, 350),
                                        new Point(350, 50),};

            activePoint = -1;
            currentPoint = new Point(0, 0);
            drawing = false;
            dragging = false;

            scaleX = 1;
            scaleY = 1;
            transX = 0;
            transY = 0;

            switch(tabIndex)
            {
                case 0:
                    {
                        outputWidth = 2048;
                        outputHeight = 2048;
                        outputX = 0;
                        outputY = 0;
                        btf = BoxTextureFile.BOXFRONT;
                        //Magic numbers I got from photoshop coordinates on the background images
                        mappedCorners = new PointF[] { new PointF(224,87),new PointF(419,35),new PointF(244,334),new PointF(395, 267) };
                    }
                    break;
                case 1:
                    {
                        outputWidth = 2048;
                        outputHeight = 2048;
                        outputX = 0;
                        outputY = 0;
                        btf = BoxTextureFile.BOXBACK;
                        //Magic numbers I got from photoshop coordinates on the background images
                        mappedCorners = new PointF[] { new PointF(180, 27), new PointF(360, 66), new PointF(200, 289), new PointF(345, 364) };
                    }
                    break;
                case 2:
                    {
                        outputWidth = 512;
                        outputHeight = 2048;
                        outputX = 512;
                        outputY = 0;
                        btf = BoxTextureFile.BOXSIDES;
                        //Magic numbers I got from photoshop coordinates on the background images
                        mappedCorners = new PointF[] { new PointF(360, 66), new PointF(403, 54), new PointF(345, 367), new PointF(385, 342) };
                    }
                    break;
                case 3:
                    {
                        outputWidth = 512;
                        outputHeight = 2048;
                        outputX = 1536;
                        outputY = 0;
                        btf = BoxTextureFile.BOXSIDES;
                        //Magic numbers I got from photoshop coordinates on the background images
                        mappedCorners = new PointF[] { new PointF(360, 73), new PointF(399, 63), new PointF(348, 334), new PointF(382, 316) };
                    }
                    break;
                case 4:
                    {
                        outputWidth = 512;
                        outputHeight = 2048;
                        outputX = 0;
                        outputY = 0;
                        btf = BoxTextureFile.BOXSIDES;
                        //Magic numbers I got from photoshop coordinates on the background images
                        mappedCorners = new PointF[] { new PointF(136, 139), new PointF(144, 64), new PointF(500, 144), new PointF(493, 68) };
                    }
                    break;
                case 5:
                    {
                        outputWidth = 512;
                        outputHeight = 2048;
                        outputX = 1024;
                        outputY = 0;
                        btf = BoxTextureFile.BOXSIDES;
                        //Magic numbers I got from photoshop coordinates on the background images
                        mappedCorners = new PointF[] { new PointF(145, 320), new PointF(140, 248), new PointF(489, 325), new PointF(500, 255) };
                    }
                    break;
                case 6:
                    {
                        outputWidth = 2048;
                        outputHeight = 2048;
                        outputX = 0;
                        outputY = 0;
                        btf = BoxTextureFile.BOXFLAPLEFT;
                        //Magic numbers I got from photoshop coordinates on the background images
                        mappedCorners = new PointF[] { new PointF(130, 59), new PointF(311, 58), new PointF(146, 334), new PointF(311, 303) };
                    }
                    break;
                case 7:
                    {
                        outputWidth = 2048;
                        outputHeight = 2048;
                        outputX = 0;
                        outputY = 0;
                        btf = BoxTextureFile.BOXFLAPRIGHT;
                        //Magic numbers I got from photoshop coordinates on the background images
                        mappedCorners = new PointF[] { new PointF(308, 55), new PointF(415, 54), new PointF(305, 297), new PointF(403, 365)  };
                    }
                    break;
            }
        }

        public void uvCornerInterfaceScaling(int width,int height)
        {
            //converting a pixel on the screen scalled photo to a pixel in the full resolution photo
            if (rawPhoto.Height > rawPhoto.Width)
            {
                scaleX = (double)((double)rawPhoto.Size.Height / (double)(height));
                transX = (double)(((double)width - ((double)rawPhoto.Width / scaleX)) / 2);
                scaleY = (double)((double)rawPhoto.Size.Height / (double)(height));
                transY = 0;
            }
            else
            {
                scaleX = (double)((double)rawPhoto.Size.Width / (double)(width));
                transX = 0;
                scaleY = (double)((double)rawPhoto.Size.Width / (double)(width));
                transY = (double)(((double)height - ((double)rawPhoto.Height / scaleY)) / 2); ;
            }
        }

        public Mat handle_DragDrop(object sender,DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //Loading a file when it is dragged in from somewhere else in the OS
                string[] filesDroped = (string[])e.Data.GetData(DataFormats.FileDrop);
                string filename = filesDroped[0];
                rawPhoto = new Mat(filename);
                ImageSizeCheck();
                return rawPhoto;
            }
            else
            {
                //Loading a file when it is dragged from the list view item in the program
                var toHandle = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                rawPhoto = new Mat(toHandle.Text);
                ImageSizeCheck();
                return  rawPhoto;
            }
        }

        public Mat handle_toolStripButtonClick(string filename)
        {
            //When you have a file in the list view selected and hit the select button the image is loaded to the tab
            rawPhoto = new Mat(filename);
            ImageSizeCheck();
            return rawPhoto;
        }

        public void ImageSizeCheck()
        {
            //Other parts the program that do image proccessing assume the image in the tab is bigger than 2048x2048
            //This scales the image up if it is smaller than that
            if(rawPhoto.Bitmap.Size.Width<2048||rawPhoto.Bitmap.Size.Height<2048)
            {
                if (rawPhoto.Bitmap.Size.Width < rawPhoto.Bitmap.Size.Height)
                {
                    double Scale = rawPhoto.Bitmap.Size.Width / 2048.0;
                    CvInvoke.Resize(rawPhoto,rawPhoto,new Size(2048,(int)(rawPhoto.Bitmap.Size.Height / Scale)));
                }
                else
                {
                    double Scale = rawPhoto.Bitmap.Size.Height / 2048.0;
                    CvInvoke.Resize(rawPhoto, rawPhoto, new Size((int)(rawPhoto.Bitmap.Size.Width / Scale),2048));
                }
            }
        }

        public Mat handel_GuessButtonClick()
        {
            Mat workingImage = new Mat();
            Mat contourImage = new Mat();

            //Make image gray scale
            CvInvoke.CvtColor(rawPhoto, contourImage, ColorConversion.Bgr2Gray);

            //Noise reduction
            UMat pyrDown = new UMat();
            CvInvoke.PyrDown(contourImage, pyrDown);
            CvInvoke.PyrUp(pyrDown, contourImage);
            CvInvoke.Threshold(contourImage, contourImage, 100, 255, ThresholdType.BinaryInv);

            VectorOfVectorOfPoint contours;
            contours = new VectorOfVectorOfPoint();
            Mat m = new Mat();

            //Find areas of contiguos color values
            CvInvoke.FindContours(contourImage, contours, m, RetrType.Ccomp, ChainApproxMethod.ChainApproxSimple);


            //Find the contour with the largest area
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

            //Aproximate the largest contour with fewers points (hopefully 4)
            VectorOfVectorOfPoint convexCOI = new VectorOfVectorOfPoint(1);
            CvInvoke.ConvexHull(contours[largestContourIndex], convexCOI[0]);
            CvInvoke.ApproxPolyDP(convexCOI[0], convexCOI[0], 100, true);


            //if the Aproximation wasn't a reduction to 4 points just take the first 4 points and user will have to fix manually
            //if less than 4 point user has to do it completely manually
            if (convexCOI[0].Size >= 4)
            {
                //Converting VectorOfVectorOfPoint to Point[] for use with the rest of the program
                uvCorners = new Point[] {new Point(convexCOI[0].ToArray().ElementAt<Point>(0).X, convexCOI[0].ToArray().ElementAt<Point>(0).Y),
                                        new Point(convexCOI[0].ToArray().ElementAt<Point>(1).X, convexCOI[0].ToArray().ElementAt<Point>(1).Y),
                                        new Point(convexCOI[0].ToArray().ElementAt<Point>(2).X, convexCOI[0].ToArray().ElementAt<Point>(2).Y),
                                        new Point(convexCOI[0].ToArray().ElementAt<Point>(3).X, convexCOI[0].ToArray().ElementAt<Point>(3).Y)};

                Mat pMatrix = new Mat();
                PointF[] temp = new PointF[] { new PointF(outputWidth, 0), new PointF(outputWidth, outputHeight), new PointF(0, outputHeight), new PointF(0, 0) };


                Point[] ctemp = convexCOI[0].ToArray();
                PointF[] coit = new PointF[4];
                for (int i = 0; i < 4; i++)
                {
                    coit[i].X = ctemp[i].X;
                    coit[i].Y = ctemp[i].Y;
                }

                pMatrix = CvInvoke.GetPerspectiveTransform(coit, temp);
                CvInvoke.WarpPerspective(rawPhoto, workingImage, pMatrix, rawPhoto.Size);
                workingImage.CopyTo(finalImage);
                Mat cropped = new Mat(finalImage, new Rectangle(0, 0, outputWidth, outputHeight));

                finalImage = cropped;
            }
            else
            {
                //In the futer I plan to add auto changing of the 3rd argument ofCvInvoke.ApproxPolyDP(convexCOI[0], convexCOI[0], 100, true);
                //To get more than 3 points in the approximation
                MessageBox.Show("Unable to guess on this one. You will have to do it by moving the corners");
            }
            return finalImage;
        }

        public void handel_Paint(object sender,PaintEventArgs e,int width, int height)
        {
            //This function draws the red lines and corner circles on top of the image in the tab
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red);            
            if (uvCorners[0] != null)
            {
                uvCornerInterfaceScaling(width, height);

                for (int i = 0; i < 4; i++)
                {
                    g.DrawEllipse(pen, (float)((uvCorners[i].X / scaleX) + transX - 2.5), (float)((uvCorners[i].Y / scaleY) + transY - 2.5), 5, 5);
                }
                g.DrawLine(pen, (float)(uvCorners[0].X / scaleX + transX), (float)(uvCorners[0].Y / scaleY + transY), (float)(uvCorners[1].X / scaleX + transX), (float)(uvCorners[1].Y / scaleY + transY));
                g.DrawLine(pen, (float)(uvCorners[1].X / scaleX + transX), (float)(uvCorners[1].Y / scaleY + transY), (float)(uvCorners[2].X / scaleX + transX), (float)(uvCorners[2].Y / scaleY + transY));
                g.DrawLine(pen, (float)(uvCorners[2].X / scaleX + transX), (float)(uvCorners[2].Y / scaleY + transY), (float)(uvCorners[3].X / scaleX + transX), (float)(uvCorners[3].Y / scaleY + transY));
                g.DrawLine(pen, (float)(uvCorners[3].X / scaleX + transX), (float)(uvCorners[3].Y / scaleY + transY), (float)(uvCorners[0].X / scaleX + transX), (float)(uvCorners[0].Y / scaleY + transY));
            }
        }

        public int CheckIfPointClicked(Point toCheck, int width, int height)
        {
            //Figures out if one of the red circles has been clicked on
            uvCornerInterfaceScaling(width, height);

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
            //Handles the realtime updating of the Preview image box of the raw texture on the top right
            Mat workingImage = rawPhoto;

            Mat pMatrix = new Mat();
            PointF[] temp = new PointF[] { new PointF(outputWidth, 0), new PointF(outputWidth, outputHeight), new PointF(0, outputHeight), new PointF(0, 0) };

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

            Mat cropped = new Mat(finalImage, new Rectangle(0, 0, outputWidth, outputHeight));

            Program.mForm.PreviewImage.Image=cropped;
            Program.mForm.PreviewImage.Invalidate();
        }

        public Bitmap DistortToMappedPreview(float wScale, float hScale)
        {
            //Handles the realtime updating of the mapped preview image box of the mapped texture on the middle right
            Mat workingImage = new Mat();
            finalImage.CopyTo(workingImage);

            Mat pMatrix = new Mat();
            PointF[] coit = new PointF[] { new PointF(0, 0), new PointF(outputWidth, 0), new PointF(0, outputHeight), new PointF(outputWidth, outputHeight) };


            PointF[] temp = new PointF[4];
            for (int i = 0; i < 4; i++)
            {
                temp[i].X=mappedCorners[i].X * wScale;
                temp[i].Y=mappedCorners[i].Y * hScale;
            }

            pMatrix = CvInvoke.GetPerspectiveTransform(coit, temp);
            CvInvoke.WarpPerspective(workingImage, workingImage, pMatrix, workingImage.Size);
            Mat cropped = new Mat(workingImage, new Rectangle(0, 0, Program.mForm.MappedPreview.Width, Program.mForm.MappedPreview.Height));
            Bitmap bitm = new Bitmap(cropped.Bitmap);
            bitm.MakeTransparent(Color.Black);

            return bitm;
        }


        public void handle_MouseDown(object sender,MouseEventArgs e,int width, int height)
        {
            if (e.Button != MouseButtons.Left) return;

            //Manages the begging of a move of one of the corners
            uvCornerInterfaceScaling(width, height);

            drawing = false;
            dragging = false;
            activePoint = CheckIfPointClicked(e.Location,width,height);
            if (activePoint != -1)
            {
                dragging = true;
                currentPoint = new Point((int)((e.Location.X - transX) * transX), (int)((e.Location.Y - transY) * transY));
                uvCorners[activePoint].X = (int)((e.Location.X - transX) * scaleX);
                uvCorners[activePoint].Y = (int)((e.Location.Y - transY) * scaleY);
                if (!drawing)//Ignore mouse events that occur before we have finished calculating the preview image
                {
                    drawing = true;// Start ignoring other mouse events till it finishes drawing
                    DistortPreviewImage(); //Calculating the texture real time preview image
                    Program.mForm.tabControlSides.SelectedTab.Refresh(); //Show where the corners and lines are right now
                    GC.Collect(); //Need to release all the temp memory that all the real time calculations use before we start calculating again.
                    drawing = false;
                }
            }
        }

        public void handle_MouseMove(object sender, MouseEventArgs e, int width, int height)
        {
            //Same as for mouseDown with relavant differences
            uvCornerInterfaceScaling(width, height);

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
                    Program.mForm.MappedPreview.Invalidate();
                    GC.Collect();
                    drawing = false;
                }
            }
        }

        public void handle_MouseUp(object sender, MouseEventArgs e, int width, int height)
        {
            //Same as for mouseDown with relavant differences
            uvCornerInterfaceScaling(width, height);

            if (dragging)
            {
                uvCorners[activePoint].X = (int)((e.Location.X - transX) * scaleX);
                uvCorners[activePoint].Y = (int)((e.Location.Y - transY) * scaleY);
                if (!drawing)
                {
                    drawing = true;
                    DistortPreviewImage();
                    Program.mForm.tabControlSides.SelectedTab.Refresh();
                    Program.mForm.MappedPreview.Invalidate();
                    GC.Collect();
                    drawing = false;
                }
            }
            dragging = false;
            activePoint = -1;

            finalImage = (Mat)Program.mForm.PreviewImage.Image;
        }
        

        public void handle_RotateCCW()
        {
            Point tempPoint = uvCorners[0];
            uvCorners[0] = uvCorners[1];
            uvCorners[1] = uvCorners[2];
            uvCorners[2] = uvCorners[3];
            uvCorners[3] = tempPoint;
            DistortPreviewImage();
            finalImage = (Mat)Program.mForm.PreviewImage.Image;
        }

        public void handle_RotateCW()
        {
            Point tempPoint = uvCorners[3];
            uvCorners[3] = uvCorners[2];
            uvCorners[2] = uvCorners[1];
            uvCorners[1] = uvCorners[0];
            uvCorners[0] = tempPoint;
            DistortPreviewImage();
            finalImage = (Mat)Program.mForm.PreviewImage.Image;
        }

        public void handel_Rotate180()
        {
            Point tempPoint = uvCorners[0];
            uvCorners[0] = uvCorners[2];
            uvCorners[2] = tempPoint;

            tempPoint = uvCorners[1];
            uvCorners[1] = uvCorners[3];
            uvCorners[3] = tempPoint;

            DistortPreviewImage();
            finalImage = (Mat)Program.mForm.PreviewImage.Image;
        }

        public void handle_MirrorHorizontal()
        {
            Point tempPoint = uvCorners[0];
            uvCorners[0] = uvCorners[3];
            uvCorners[3] = tempPoint;

            tempPoint = uvCorners[1];
            uvCorners[1] = uvCorners[2];
            uvCorners[2] = tempPoint;

            DistortPreviewImage();
            finalImage = (Mat)Program.mForm.PreviewImage.Image;
        }

        public void handle_MirrorVertical()
        {            
            Point tempPoint = uvCorners[0];
            uvCorners[0] = uvCorners[1];
            uvCorners[1] = tempPoint;

            tempPoint = uvCorners[2];
            uvCorners[2] = uvCorners[3];
            uvCorners[3] = tempPoint;

            DistortPreviewImage();
            finalImage = (Mat)Program.mForm.PreviewImage.Image;
        }
    }
}