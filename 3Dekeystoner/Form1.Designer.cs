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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextContourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.finalImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineImageBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // finalImageBox
            // 
            this.finalImageBox.Location = new System.Drawing.Point(12, 27);
            this.finalImageBox.Name = "finalImageBox";
            this.finalImageBox.Size = new System.Drawing.Size(643, 812);
            this.finalImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finalImageBox.TabIndex = 2;
            this.finalImageBox.TabStop = false;
            // 
            // lineImageBox
            // 
            this.lineImageBox.Location = new System.Drawing.Point(661, 27);
            this.lineImageBox.Name = "lineImageBox";
            this.lineImageBox.Size = new System.Drawing.Size(676, 812);
            this.lineImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lineImageBox.TabIndex = 2;
            this.lineImageBox.TabStop = false;
            this.lineImageBox.Click += new System.EventHandler(this.lineImageBox_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1349, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextContourToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // nextContourToolStripMenuItem
            // 
            this.nextContourToolStripMenuItem.Name = "nextContourToolStripMenuItem";
            this.nextContourToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nextContourToolStripMenuItem.Text = "Next Contour";
            this.nextContourToolStripMenuItem.Click += new System.EventHandler(this.nextContourToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 851);
            this.Controls.Add(this.lineImageBox);
            this.Controls.Add(this.finalImageBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finalImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineImageBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Emgu.CV.UI.ImageBox finalImageBox;
        private Emgu.CV.UI.ImageBox lineImageBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextContourToolStripMenuItem;
    }
}

