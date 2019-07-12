namespace _3Dekeystoner
{
    partial class ExportTexturesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fbdExportLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.labelPath = new System.Windows.Forms.Label();
            this.btnChooseDirectory = new System.Windows.Forms.Button();
            this.ibExportFront = new Emgu.CV.UI.ImageBox();
            this.ibExportBack = new Emgu.CV.UI.ImageBox();
            this.ibExportSides = new Emgu.CV.UI.ImageBox();
            this.ibExportFlapLeft = new Emgu.CV.UI.ImageBox();
            this.ibExportFlapRight = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ibExportFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibExportBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibExportSides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibExportFlapLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibExportFlapRight)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(44, 45);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(22, 13);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "C:\\";
            // 
            // button1
            // 
            this.btnChooseDirectory.Location = new System.Drawing.Point(12, 12);
            this.btnChooseDirectory.Name = "button1";
            this.btnChooseDirectory.Size = new System.Drawing.Size(134, 23);
            this.btnChooseDirectory.TabIndex = 1;
            this.btnChooseDirectory.Text = "Choose Export Folder";
            this.btnChooseDirectory.UseVisualStyleBackColor = true;
            this.btnChooseDirectory.Click += new System.EventHandler(this.btnChooseDirectory_Click);
            // 
            // ibExportFront
            // 
            this.ibExportFront.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.ibExportFront.Location = new System.Drawing.Point(12, 88);
            this.ibExportFront.Name = "ibExportFront";
            this.ibExportFront.Size = new System.Drawing.Size(200, 200);
            this.ibExportFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibExportFront.TabIndex = 2;
            this.ibExportFront.TabStop = false;
            // 
            // ibExportBack
            // 
            this.ibExportBack.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.ibExportBack.Location = new System.Drawing.Point(12, 325);
            this.ibExportBack.Name = "ibExportBack";
            this.ibExportBack.Size = new System.Drawing.Size(200, 200);
            this.ibExportBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibExportBack.TabIndex = 3;
            this.ibExportBack.TabStop = false;
            // 
            // ibExportSides
            // 
            this.ibExportSides.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.ibExportSides.Location = new System.Drawing.Point(236, 88);
            this.ibExportSides.Name = "ibExportSides";
            this.ibExportSides.Size = new System.Drawing.Size(200, 200);
            this.ibExportSides.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibExportSides.TabIndex = 4;
            this.ibExportSides.TabStop = false;
            // 
            // ibExportFlapLeft
            // 
            this.ibExportFlapLeft.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.ibExportFlapLeft.Location = new System.Drawing.Point(236, 325);
            this.ibExportFlapLeft.Name = "ibExportFlapLeft";
            this.ibExportFlapLeft.Size = new System.Drawing.Size(200, 200);
            this.ibExportFlapLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibExportFlapLeft.TabIndex = 5;
            this.ibExportFlapLeft.TabStop = false;
            // 
            // ibExportFlapRight
            // 
            this.ibExportFlapRight.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.ibExportFlapRight.Location = new System.Drawing.Point(460, 325);
            this.ibExportFlapRight.Name = "ibExportFlapRight";
            this.ibExportFlapRight.Size = new System.Drawing.Size(200, 200);
            this.ibExportFlapRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibExportFlapRight.TabIndex = 6;
            this.ibExportFlapRight.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Box_Front.jpg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Box_Sides.jpg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Box_Back.jpg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Box_Flap_Left.jpg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Box_Flap_Right.jpg";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(460, 88);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(90, 23);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Save Textures";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ExportTexturesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 537);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ibExportFlapRight);
            this.Controls.Add(this.ibExportFlapLeft);
            this.Controls.Add(this.ibExportSides);
            this.Controls.Add(this.ibExportBack);
            this.Controls.Add(this.ibExportFront);
            this.Controls.Add(this.btnChooseDirectory);
            this.Controls.Add(this.labelPath);
            this.Name = "ExportTexturesForm";
            this.Text = "Export Textures";
            ((System.ComponentModel.ISupportInitialize)(this.ibExportFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibExportBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibExportSides)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibExportFlapLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibExportFlapRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdExportLocation;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button btnChooseDirectory;
        private Emgu.CV.UI.ImageBox ibExportFront;
        private Emgu.CV.UI.ImageBox ibExportBack;
        private Emgu.CV.UI.ImageBox ibExportSides;
        private Emgu.CV.UI.ImageBox ibExportFlapLeft;
        private Emgu.CV.UI.ImageBox ibExportFlapRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExport;
    }
}