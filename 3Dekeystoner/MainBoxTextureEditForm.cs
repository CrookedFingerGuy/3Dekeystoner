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
using System.Resources;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace _3Dekeystoner
{
    public partial class MainBoxTextureEditForm : Form
    {       
        
        public UVEditTabPageData[] uvEditData;
        public Mat rFront;
        public Mat rBackAndLeft;
        public Mat rRight;
        public Mat rFlapsAndRight;
        public Mat rTop;
        public Mat rBottom;

        public MainBoxTextureEditForm()
        {
            InitializeComponent();
            rFront = new Image<Bgra, byte>(Properties.Resources.Front).Mat;
            rBackAndLeft = new Image<Bgra, byte>(Properties.Resources.BackAndLeft).Mat;
            rFlapsAndRight = new Image<Bgra, byte>(Properties.Resources.FlapsAndRight).Mat;
            rRight=new Image<Bgra, byte>(Properties.Resources.Right).Mat;
            rTop = new Image<Bgra, byte>(Properties.Resources.Top).Mat;
            rBottom = new Image<Bgra, byte>(Properties.Resources.Bottom).Mat;
            MappedPreview.Image = rFront;
            imageBoxFront.AllowDrop = true;
            imageBoxBack.AllowDrop = true;
            imageBoxLeft.AllowDrop = true;
            imageBoxRight.AllowDrop = true;
            imageBoxTop.AllowDrop = true;
            imageBoxBottom.AllowDrop = true;
            imageBoxFlapLeft.AllowDrop = true;
            imageBoxFlapRight.AllowDrop = true;
            listView1.AllowDrop = true;
            listView1.MultiSelect = false;
            uvEditData = new UVEditTabPageData[tabControlSides.TabCount];
            for(int i=0;i<tabControlSides.TabCount;i++)
            {
                uvEditData[i]=new UVEditTabPageData(i);
            }
        }


        private void openFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openJPG = new OpenFileDialog();
            openJPG.Multiselect = true;
            if (openJPG.ShowDialog() == DialogResult.OK)
            {
                foreach(string file in openJPG.FileNames)
                {
                    imageList1.Images.Add(file,Image.FromFile(file));
                    listView1.Items.Add(file, imageList1.Images.IndexOfKey(file));
                }
            }
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(listView1.SelectedItems[0], DragDropEffects.Copy);
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            if (!uvEditData[tabControlSides.SelectedIndex].rawPhoto.Size.IsEmpty)
            {
                PreviewImage.Image = uvEditData[tabControlSides.SelectedIndex].handel_GuessButtonClick();
                PreviewImage.Invalidate();
                tabControlSides.Invalidate();
                MappedPreview.Invalidate();
            }
            else
            {
                MessageBox.Show("You need to select an image to put on this tab before guessing.");
            }
        }


        private void PreviewImage_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                switch (tabControlSides.SelectedIndex)
                {
                    case 0:
                        {
                            imageBoxFront.Image = uvEditData[tabControlSides.SelectedIndex].handle_toolStripButtonClick(listView1.SelectedItems[0].Text);
                        }
                        break;
                    case 1:
                        {
                            imageBoxBack.Image = uvEditData[tabControlSides.SelectedIndex].handle_toolStripButtonClick(listView1.SelectedItems[0].Text);
                        }
                        break;
                    case 2:
                        {
                            imageBoxLeft.Image = uvEditData[tabControlSides.SelectedIndex].handle_toolStripButtonClick(listView1.SelectedItems[0].Text);
                        }
                        break;
                    case 3:
                        {
                            imageBoxRight.Image = uvEditData[tabControlSides.SelectedIndex].handle_toolStripButtonClick(listView1.SelectedItems[0].Text);
                        }
                        break;
                    case 4:
                        {
                            imageBoxTop.Image = uvEditData[tabControlSides.SelectedIndex].handle_toolStripButtonClick(listView1.SelectedItems[0].Text);
                        }
                        break;
                    case 5:
                        {
                            imageBoxBottom.Image = uvEditData[tabControlSides.SelectedIndex].handle_toolStripButtonClick(listView1.SelectedItems[0].Text);
                        }
                        break;
                    case 6:
                        {
                            imageBoxFlapLeft.Image = uvEditData[tabControlSides.SelectedIndex].handle_toolStripButtonClick(listView1.SelectedItems[0].Text);
                        }
                        break;
                    case 7:
                        {
                            imageBoxFlapRight.Image = uvEditData[tabControlSides.SelectedIndex].handle_toolStripButtonClick(listView1.SelectedItems[0].Text);
                        }
                        break;
                }
            }
        }

        private void cVStepsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebugForm df = new DebugForm();
            df.Show();
        }

        private void imageBoxFront_DragDrop(object sender, DragEventArgs e)
        {
            imageBoxFront.Image = uvEditData[tabControlSides.SelectedIndex].handle_DragDrop(sender,e);
        }

        private void imageBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void imageBox_Paint(object sender, PaintEventArgs e)
        {
            uvEditData[tabControlSides.SelectedIndex].handel_Paint(sender, e,imageBoxFront.Width,imageBoxFront.Height);
        }

        private void imageBox_MouseDown(object sender, MouseEventArgs e)
        {
            uvEditData[tabControlSides.SelectedIndex].handle_MouseDown(sender, e, imageBoxFront.Width, imageBoxFront.Height);
        }

        private void imageBox_MouseMove(object sender, MouseEventArgs e)
        {
            uvEditData[tabControlSides.SelectedIndex].handle_MouseMove(sender, e, imageBoxFront.Width, imageBoxFront.Height);
        }

        private void imageBox_MouseUp(object sender, MouseEventArgs e)
        {
            uvEditData[tabControlSides.SelectedIndex].handle_MouseUp(sender, e, imageBoxFront.Width, imageBoxFront.Height);
        }

        private void imageBoxBack_DragDrop(object sender, DragEventArgs e)
        {
            imageBoxBack.Image = uvEditData[tabControlSides.SelectedIndex].handle_DragDrop(sender, e);
        }

        private void imageBoxLeft_DragDrop(object sender, DragEventArgs e)
        {
            imageBoxLeft.Image = uvEditData[tabControlSides.SelectedIndex].handle_DragDrop(sender, e);
        }

        private void imageBoxRight_DragDrop(object sender, DragEventArgs e)
        {
            imageBoxRight.Image = uvEditData[tabControlSides.SelectedIndex].handle_DragDrop(sender, e);
        }

        private void imageBoxTop_DragDrop(object sender, DragEventArgs e)
        {
            imageBoxTop.Image = uvEditData[tabControlSides.SelectedIndex].handle_DragDrop(sender, e);
        }

        private void imageBoxBottom_DragDrop(object sender, DragEventArgs e)
        {
            imageBoxBottom.Image = uvEditData[tabControlSides.SelectedIndex].handle_DragDrop(sender, e);
        }

        private void imageBoxFlapLeft_DragDrop(object sender, DragEventArgs e)
        {
            imageBoxFlapLeft.Image = uvEditData[tabControlSides.SelectedIndex].handle_DragDrop(sender, e);
        }

        private void imageBoxFlapRight_DragDrop(object sender, DragEventArgs e)
        {
            imageBoxFlapRight.Image = uvEditData[tabControlSides.SelectedIndex].handle_DragDrop(sender, e);
        }

        private void tabControlSides_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabControlSides.SelectedIndex)
            {
                case 0:
                    {
                        MappedPreview.Image = rFront;
                    }
                    break;
                case 1:
                case 2:
                    {
                        MappedPreview.Image = rBackAndLeft;
                    }
                    break;
                case 3:
                    {
                        MappedPreview.Image = rRight;
                    }
                    break;
                case 6:
                case 7:
                    {
                        MappedPreview.Image = rFlapsAndRight;
                    }
                    break;
                case 4:
                    {
                        MappedPreview.Image = rTop;
                    }
                    break;
                case 5:
                    {
                        MappedPreview.Image = rBottom;
                    }
                    break;
            }

            if (uvEditData[tabControlSides.SelectedIndex].finalImage.Bitmap != null)
                if (!uvEditData[tabControlSides.SelectedIndex].finalImage.Bitmap.Size.IsEmpty)
                {
                    PreviewImage.Image = uvEditData[tabControlSides.SelectedIndex].finalImage;
                    PreviewImage.Invalidate();
                    MappedPreview.Invalidate();
                }
        }

        private void btnRotateCW_Click(object sender, EventArgs e)
        {
            if (uvEditData[tabControlSides.SelectedIndex].finalImage.Bitmap != null)
                if (!uvEditData[tabControlSides.SelectedIndex].finalImage.Bitmap.Size.IsEmpty)
                {
                    uvEditData[tabControlSides.SelectedIndex].handle_RotateCW();
                    PreviewImage.Invalidate();
                    MappedPreview.Invalidate();
                }
        }

        private void btnRotateCCW_Click(object sender, EventArgs e)
        {
            if (uvEditData[tabControlSides.SelectedIndex].finalImage.Bitmap != null)
                if (!uvEditData[tabControlSides.SelectedIndex].finalImage.Bitmap.Size.IsEmpty)
                {
                    uvEditData[tabControlSides.SelectedIndex].handle_RotateCCW();
                    PreviewImage.Invalidate();
                    MappedPreview.Invalidate();
                }
        }

        private void exportTexturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportTexturesForm etForm = new ExportTexturesForm();
            etForm.Show();
        }

        private void MappedPreview_Paint(object sender, PaintEventArgs e)
        {
            if(uvEditData[tabControlSides.SelectedIndex].finalImage.Bitmap!= null)
                if (!uvEditData[tabControlSides.SelectedIndex].finalImage.Bitmap.Size.IsEmpty)
                {
                    Graphics g = e.Graphics;
                    Pen pen = new Pen(Color.Red);
                    float wScale = (float)((float)MappedPreview.Width / 600.0);
                    float hScale = (float)((float)MappedPreview.Height / 400.0);
                    float zoomScale = (float)((float)MappedPreview.Height / 198.0);//198 is MappedPreview.Height at the program start
                    g.DrawImage(uvEditData[tabControlSides.SelectedIndex].DistortToMappedPreview(wScale, hScale), 0, (MappedPreview.Height-MappedPreview.Height/zoomScale)/2, MappedPreview.Width, MappedPreview.Height/zoomScale);
                }
        }

        private void btnMirrorHorizontal_Click(object sender, EventArgs e)
        {
            if (uvEditData[tabControlSides.SelectedIndex].finalImage.Bitmap != null)
                if (!uvEditData[tabControlSides.SelectedIndex].finalImage.Bitmap.Size.IsEmpty)
                {
                    uvEditData[tabControlSides.SelectedIndex].handle_MirrorHorizontal();
                    PreviewImage.Invalidate();
                    MappedPreview.Invalidate();
                }
        }

        private void btnMirrorVertical_Click(object sender, EventArgs e)
        {
            if (uvEditData[tabControlSides.SelectedIndex].finalImage.Bitmap != null)
                if (!uvEditData[tabControlSides.SelectedIndex].finalImage.Bitmap.Size.IsEmpty)
                {
                    uvEditData[tabControlSides.SelectedIndex].handle_MirrorVertical();
                    PreviewImage.Invalidate();
                    MappedPreview.Invalidate();
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uvEditData[tabControlSides.SelectedIndex].finalImage.Bitmap != null)
                if (!uvEditData[tabControlSides.SelectedIndex].finalImage.Bitmap.Size.IsEmpty)
                {
                    uvEditData[tabControlSides.SelectedIndex].handel_Rotate180();
                    PreviewImage.Invalidate();
                    MappedPreview.Invalidate();
                }
        }
    }
}
