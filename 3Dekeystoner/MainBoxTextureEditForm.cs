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


        public MainBoxTextureEditForm()
        {
            InitializeComponent();
            imageBoxFront.AllowDrop = true;
            listView1.AllowDrop = true;
            listView1.MultiSelect = false;
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

            var toHandle = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            FrontMat = new Mat(toHandle.ImageKey);
            imageBoxFront.Image = FrontMat;
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
    }
}
