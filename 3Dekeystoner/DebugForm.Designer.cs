namespace _3Dekeystoner
{
    partial class DebugForm
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.imageBox4 = new Emgu.CV.UI.ImageBox();
            this.imageBox5 = new Emgu.CV.UI.ImageBox();
            this.imageBox6 = new Emgu.CV.UI.ImageBox();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem2.Text = "&Open...";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1012, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel1.Text = "No File Loaded";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 355F));
            this.tableLayoutPanel1.Controls.Add(this.imageBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.imageBox5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.imageBox6, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1012, 513);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.Location = new System.Drawing.Point(3, 3);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(322, 250);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox2.Location = new System.Drawing.Point(331, 3);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(322, 250);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox3.Location = new System.Drawing.Point(659, 3);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(350, 250);
            this.imageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox3.TabIndex = 2;
            this.imageBox3.TabStop = false;
            // 
            // imageBox4
            // 
            this.imageBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox4.Location = new System.Drawing.Point(3, 259);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(322, 251);
            this.imageBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox4.TabIndex = 2;
            this.imageBox4.TabStop = false;
            // 
            // imageBox5
            // 
            this.imageBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox5.Location = new System.Drawing.Point(331, 259);
            this.imageBox5.Name = "imageBox5";
            this.imageBox5.Size = new System.Drawing.Size(322, 251);
            this.imageBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox5.TabIndex = 2;
            this.imageBox5.TabStop = false;
            // 
            // imageBox6
            // 
            this.imageBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox6.Location = new System.Drawing.Point(659, 259);
            this.imageBox6.Name = "imageBox6";
            this.imageBox6.Size = new System.Drawing.Size(350, 251);
            this.imageBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox6.TabIndex = 2;
            this.imageBox6.TabStop = false;
            // 
            // DebugForm
            // 
            this.ClientSize = new System.Drawing.Size(1012, 559);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "DebugForm";
            this.Text = "Image Processing Debug Window";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Emgu.CV.UI.ImageBox finalImageBox;
        private Emgu.CV.UI.ImageBox lineImageBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox3;
        private Emgu.CV.UI.ImageBox imageBox4;
        private Emgu.CV.UI.ImageBox imageBox5;
        private Emgu.CV.UI.ImageBox imageBox6;
    }
}

