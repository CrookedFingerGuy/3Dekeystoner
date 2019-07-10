using System;
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
            exportPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\3DProjects\\Testing";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(fbdExportLocation.ShowDialog()==DialogResult.OK)
            {
                exportPath = fbdExportLocation.SelectedPath;
                labelPath.Text = exportPath;
            }
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(FrontFile!=null) FrontFile.Save(exportPath + "\\Box_Front.jpg");
            if(BackFile!=null) BackFile.Save(exportPath + "\\Box_Back.jpg");
            if(SidesFile!=null) SidesFile.Save(exportPath + "\\Box_Sides.jpg");
            if(FlapLeftFile!=null) FlapLeftFile.Save(exportPath + "\\Box_Flap_Left.jpg");
            if(FlapRightFile!=null) FlapRightFile.Save(exportPath + "\\Box_Flap_Right.jpg");
        }
    }
}
