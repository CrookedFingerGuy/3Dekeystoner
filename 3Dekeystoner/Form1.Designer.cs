namespace _3Dekeystoner
{
    partial class Form1
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
            this.finalImageBox = new Emgu.CV.UI.ImageBox();
            this.lineImageBox = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.finalImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // triangleRectangleImageBox
            // 
            this.finalImageBox.Location = new System.Drawing.Point(12, 12);
            this.finalImageBox.Name = "triangleRectangleImageBox";
            this.finalImageBox.Size = new System.Drawing.Size(643, 827);
            this.finalImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finalImageBox.TabIndex = 2;
            this.finalImageBox.TabStop = false;
            // 
            // lineImageBox
            // 
            this.lineImageBox.Location = new System.Drawing.Point(661, 12);
            this.lineImageBox.Name = "lineImageBox";
            this.lineImageBox.Size = new System.Drawing.Size(676, 827);
            this.lineImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lineImageBox.TabIndex = 2;
            this.lineImageBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 851);
            this.Controls.Add(this.lineImageBox);
            this.Controls.Add(this.finalImageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finalImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Emgu.CV.UI.ImageBox finalImageBox;
        private Emgu.CV.UI.ImageBox lineImageBox;
    }
}

