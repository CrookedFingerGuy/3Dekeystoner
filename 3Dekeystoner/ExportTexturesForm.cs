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
    public partial class ExportTexturesForm : Form
    {

        public string exportPath;
        public Mat FrontFile;
        public Mat BackFile;
        public Mat SidesFile;
        public Mat FlapLeftFile;
        public Mat FlapRightFile;

        public ExportTexturesForm()
        {
            InitializeComponent();
            exportPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            labelPath.Text = exportPath;
            if (Program.mForm.uvEditData[0].finalImage != null)
            {
                FrontFile = new Mat();
                FrontFile = Program.mForm.uvEditData[0].finalImage;
                ibExportFront.Image = FrontFile;
            }

            if (Program.mForm.uvEditData[1].finalImage != null)
            {
                BackFile = new Mat();
                BackFile = Program.mForm.uvEditData[1].finalImage;
                ibExportBack.Image = BackFile;
            }

            SidesFile = new Mat();

            if ((Program.mForm.uvEditData[2].finalImage != null)||(Program.mForm.uvEditData[3].finalImage != null))
            {
                CvInvoke.HConcat(Program.mForm.uvEditData[2].finalImage, Program.mForm.uvEditData[3].finalImage, SidesFile);
                CvInvoke.HConcat(SidesFile, Program.mForm.uvEditData[5].finalImage, SidesFile);
                CvInvoke.HConcat(SidesFile, Program.mForm.uvEditData[4].finalImage, SidesFile);
                ibExportSides.Image = SidesFile;
            }


            if (Program.mForm.uvEditData[6].finalImage != null)
            {
                FlapLeftFile = new Mat();
                FlapLeftFile = Program.mForm.uvEditData[6].finalImage;
                ibExportFlapLeft.Image = FlapLeftFile;
            }

            if (Program.mForm.uvEditData[7].finalImage != null)
            {
                FlapRightFile = new Mat();
                FlapRightFile = Program.mForm.uvEditData[7].finalImage;
                ibExportFlapRight.Image = FlapRightFile;
            }
        }

        private void btnChooseDirectory_Click(object sender, EventArgs e)
        {
            if(Directory.Exists( labelPath.Text))
            {
                fbdExportLocation.SelectedPath = labelPath.Text;
            }
            else
            {
                fbdExportLocation.SelectedPath= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }

            if(fbdExportLocation.ShowDialog()==DialogResult.OK)
            {
                exportPath = fbdExportLocation.SelectedPath;
                labelPath.Text = exportPath;
            }
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(exportPath))
                {
                    if (!FrontFile.IsEmpty) FrontFile.Save(exportPath + "\\Box_Front.jpg");
                    if (!BackFile.Size.IsEmpty) BackFile.Save(exportPath + "\\Box_Back.jpg");
                    if (!SidesFile.IsEmpty) SidesFile.Save(exportPath + "\\Box_Sides.jpg");
                    if (!FlapLeftFile.IsEmpty) FlapLeftFile.Save(exportPath + "\\Box_Flap_Left.jpg");
                    if (!FlapRightFile.IsEmpty) FlapRightFile.Save(exportPath + "\\Box_Flap_Right.jpg");
                    if (Program.mForm.toolStripCBProjectType.SelectedIndex == 0)
                    {
                        byte[] resName = Properties.Resources.Small_Flap_Box;
                        FileStream fileStream = new FileStream(exportPath + "\\small_Flap_Box.blend", FileMode.Create);
                        for (int i = 0; i < resName.Length; i++)
                            fileStream.WriteByte(resName[i]);
                        fileStream.Close();
                    }
                    else
                    {
                        byte[] resName = Properties.Resources.Small_Box;
                        FileStream fileStream = new FileStream(exportPath + "\\small_Box.blend", FileMode.Create);
                        for (int i = 0; i < resName.Length; i++)
                            fileStream.WriteByte(resName[i]);
                        fileStream.Close();
                    }
                }
                else
                {
                    btnChooseDirectory_Click(sender, e);
                    if (!FrontFile.IsEmpty) FrontFile.Save(exportPath + "\\Box_Front.jpg");
                    if (!BackFile.Size.IsEmpty) BackFile.Save(exportPath + "\\Box_Back.jpg");
                    if (!SidesFile.IsEmpty) SidesFile.Save(exportPath + "\\Box_Sides.jpg");
                    if (!FlapLeftFile.IsEmpty) FlapLeftFile.Save(exportPath + "\\Box_Flap_Left.jpg");
                    if (!FlapRightFile.IsEmpty) FlapRightFile.Save(exportPath + "\\Box_Flap_Right.jpg");
                    if (Program.mForm.toolStripCBProjectType.SelectedIndex == 0)
                    {
                        byte[] resName = Properties.Resources.Small_Flap_Box;
                        FileStream fileStream = new FileStream(exportPath + "\\small_Flap_Box.blend", FileMode.Create);
                        for (int i = 0; i < resName.Length; i++)
                            fileStream.WriteByte(resName[i]);
                        fileStream.Close();
                    }
                    else
                    {
                        byte[] resName = Properties.Resources.Small_Box;
                        FileStream fileStream = new FileStream(exportPath + "\\small_Box.blend", FileMode.Create);
                        for (int i = 0; i < resName.Length; i++)
                            fileStream.WriteByte(resName[i]);
                        fileStream.Close();
                    }
                }
                MessageBox.Show("Export Complete");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString());
            }
        }
    }
}
