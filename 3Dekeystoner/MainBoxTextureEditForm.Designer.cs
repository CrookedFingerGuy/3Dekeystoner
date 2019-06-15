namespace _3Dekeystoner
{
    partial class MainBoxTextureEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBoxTextureEditForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.buttonGuess = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControlSides = new System.Windows.Forms.TabControl();
            this.tabPageFront = new System.Windows.Forms.TabPage();
            this.imageBoxFront = new Emgu.CV.UI.ImageBox();
            this.tabPageBack = new System.Windows.Forms.TabPage();
            this.imageBoxBack = new Emgu.CV.UI.ImageBox();
            this.tabPageLeft = new System.Windows.Forms.TabPage();
            this.imageBoxLeft = new Emgu.CV.UI.ImageBox();
            this.tabPageRight = new System.Windows.Forms.TabPage();
            this.imageBoxRight = new Emgu.CV.UI.ImageBox();
            this.tabPageTop = new System.Windows.Forms.TabPage();
            this.imageBoxTop = new Emgu.CV.UI.ImageBox();
            this.tabPageBottom = new System.Windows.Forms.TabPage();
            this.imageBoxBottom = new Emgu.CV.UI.ImageBox();
            this.tabPageFlapLeft = new System.Windows.Forms.TabPage();
            this.imageBoxFlapLeft = new Emgu.CV.UI.ImageBox();
            this.tabPageFlapRight = new System.Windows.Forms.TabPage();
            this.imageBoxFlapRight = new Emgu.CV.UI.ImageBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PreviewImage = new Emgu.CV.UI.ImageBox();
            this.MappedPreview = new Emgu.CV.UI.ImageBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControlSides.SuspendLayout();
            this.tabPageFront.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFront)).BeginInit();
            this.tabPageBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxBack)).BeginInit();
            this.tabPageLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLeft)).BeginInit();
            this.tabPageRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxRight)).BeginInit();
            this.tabPageTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxTop)).BeginInit();
            this.tabPageBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxBottom)).BeginInit();
            this.tabPageFlapLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFlapLeft)).BeginInit();
            this.tabPageFlapRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFlapRight)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MappedPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1252, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFilesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFilesToolStripMenuItem
            // 
            this.openFilesToolStripMenuItem.Name = "openFilesToolStripMenuItem";
            this.openFilesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.openFilesToolStripMenuItem.Text = "Open Files... ";
            this.openFilesToolStripMenuItem.Click += new System.EventHandler(this.openFilesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.buttonGuess});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1252, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(42, 22);
            this.toolStripButton1.Text = "Select";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // buttonGuess
            // 
            this.buttonGuess.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonGuess.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuess.Image")));
            this.buttonGuess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(42, 22);
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1252, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 305F));
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControlSides, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 607F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1252, 610);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(253, 598);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView1_ItemDrag);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabControlSides
            // 
            this.tabControlSides.AllowDrop = true;
            this.tabControlSides.Controls.Add(this.tabPageFront);
            this.tabControlSides.Controls.Add(this.tabPageBack);
            this.tabControlSides.Controls.Add(this.tabPageLeft);
            this.tabControlSides.Controls.Add(this.tabPageRight);
            this.tabControlSides.Controls.Add(this.tabPageTop);
            this.tabControlSides.Controls.Add(this.tabPageBottom);
            this.tabControlSides.Controls.Add(this.tabPageFlapLeft);
            this.tabControlSides.Controls.Add(this.tabPageFlapRight);
            this.tabControlSides.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSides.Location = new System.Drawing.Point(268, 6);
            this.tabControlSides.Name = "tabControlSides";
            this.tabControlSides.SelectedIndex = 0;
            this.tabControlSides.Size = new System.Drawing.Size(669, 598);
            this.tabControlSides.TabIndex = 1;
            // 
            // tabPageFront
            // 
            this.tabPageFront.Controls.Add(this.imageBoxFront);
            this.tabPageFront.Location = new System.Drawing.Point(4, 22);
            this.tabPageFront.Name = "tabPageFront";
            this.tabPageFront.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFront.Size = new System.Drawing.Size(661, 572);
            this.tabPageFront.TabIndex = 0;
            this.tabPageFront.Text = "Front";
            this.tabPageFront.UseVisualStyleBackColor = true;
            // 
            // imageBoxFront
            // 
            this.imageBoxFront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxFront.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBoxFront.Location = new System.Drawing.Point(3, 3);
            this.imageBoxFront.Margin = new System.Windows.Forms.Padding(0);
            this.imageBoxFront.Name = "imageBoxFront";
            this.imageBoxFront.Size = new System.Drawing.Size(655, 566);
            this.imageBoxFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxFront.TabIndex = 2;
            this.imageBoxFront.TabStop = false;
            this.imageBoxFront.DragDrop += new System.Windows.Forms.DragEventHandler(this.imageBoxFront_DragDrop);
            this.imageBoxFront.DragEnter += new System.Windows.Forms.DragEventHandler(this.imageBoxFront_DragEnter);
            this.imageBoxFront.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBoxFront_Paint);
            this.imageBoxFront.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBoxFront_MouseDown);
            this.imageBoxFront.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBoxFront_MouseMove);
            this.imageBoxFront.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBoxFront_MouseUp);
            // 
            // tabPageBack
            // 
            this.tabPageBack.Controls.Add(this.imageBoxBack);
            this.tabPageBack.Location = new System.Drawing.Point(4, 22);
            this.tabPageBack.Name = "tabPageBack";
            this.tabPageBack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBack.Size = new System.Drawing.Size(661, 572);
            this.tabPageBack.TabIndex = 1;
            this.tabPageBack.Text = "Back";
            this.tabPageBack.UseVisualStyleBackColor = true;
            // 
            // imageBoxBack
            // 
            this.imageBoxBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxBack.Location = new System.Drawing.Point(3, 3);
            this.imageBoxBack.Name = "imageBoxBack";
            this.imageBoxBack.Size = new System.Drawing.Size(655, 566);
            this.imageBoxBack.TabIndex = 2;
            this.imageBoxBack.TabStop = false;
            // 
            // tabPageLeft
            // 
            this.tabPageLeft.Controls.Add(this.imageBoxLeft);
            this.tabPageLeft.Location = new System.Drawing.Point(4, 22);
            this.tabPageLeft.Name = "tabPageLeft";
            this.tabPageLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPageLeft.Size = new System.Drawing.Size(661, 572);
            this.tabPageLeft.TabIndex = 2;
            this.tabPageLeft.Text = "Left Side";
            this.tabPageLeft.UseVisualStyleBackColor = true;
            // 
            // imageBoxLeft
            // 
            this.imageBoxLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxLeft.Location = new System.Drawing.Point(0, 0);
            this.imageBoxLeft.Name = "imageBoxLeft";
            this.imageBoxLeft.Size = new System.Drawing.Size(661, 572);
            this.imageBoxLeft.TabIndex = 2;
            this.imageBoxLeft.TabStop = false;
            // 
            // tabPageRight
            // 
            this.tabPageRight.Controls.Add(this.imageBoxRight);
            this.tabPageRight.Location = new System.Drawing.Point(4, 22);
            this.tabPageRight.Name = "tabPageRight";
            this.tabPageRight.Size = new System.Drawing.Size(661, 572);
            this.tabPageRight.TabIndex = 3;
            this.tabPageRight.Text = "Right Side";
            this.tabPageRight.UseVisualStyleBackColor = true;
            // 
            // imageBoxRight
            // 
            this.imageBoxRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxRight.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBoxRight.Location = new System.Drawing.Point(0, 0);
            this.imageBoxRight.Name = "imageBoxRight";
            this.imageBoxRight.Size = new System.Drawing.Size(661, 572);
            this.imageBoxRight.TabIndex = 2;
            this.imageBoxRight.TabStop = false;
            this.imageBoxRight.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBoxRight_Paint);
            // 
            // tabPageTop
            // 
            this.tabPageTop.Controls.Add(this.imageBoxTop);
            this.tabPageTop.Location = new System.Drawing.Point(4, 22);
            this.tabPageTop.Name = "tabPageTop";
            this.tabPageTop.Size = new System.Drawing.Size(661, 572);
            this.tabPageTop.TabIndex = 4;
            this.tabPageTop.Text = "Top";
            this.tabPageTop.UseVisualStyleBackColor = true;
            // 
            // imageBoxTop
            // 
            this.imageBoxTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxTop.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBoxTop.Location = new System.Drawing.Point(0, 0);
            this.imageBoxTop.Name = "imageBoxTop";
            this.imageBoxTop.Size = new System.Drawing.Size(661, 572);
            this.imageBoxTop.TabIndex = 2;
            this.imageBoxTop.TabStop = false;
            // 
            // tabPageBottom
            // 
            this.tabPageBottom.Controls.Add(this.imageBoxBottom);
            this.tabPageBottom.Location = new System.Drawing.Point(4, 22);
            this.tabPageBottom.Name = "tabPageBottom";
            this.tabPageBottom.Size = new System.Drawing.Size(661, 572);
            this.tabPageBottom.TabIndex = 5;
            this.tabPageBottom.Text = "Bottom";
            this.tabPageBottom.UseVisualStyleBackColor = true;
            // 
            // imageBoxBottom
            // 
            this.imageBoxBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxBottom.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBoxBottom.Location = new System.Drawing.Point(0, 0);
            this.imageBoxBottom.Name = "imageBoxBottom";
            this.imageBoxBottom.Size = new System.Drawing.Size(661, 572);
            this.imageBoxBottom.TabIndex = 2;
            this.imageBoxBottom.TabStop = false;
            // 
            // tabPageFlapLeft
            // 
            this.tabPageFlapLeft.Controls.Add(this.imageBoxFlapLeft);
            this.tabPageFlapLeft.Location = new System.Drawing.Point(4, 22);
            this.tabPageFlapLeft.Name = "tabPageFlapLeft";
            this.tabPageFlapLeft.Size = new System.Drawing.Size(661, 572);
            this.tabPageFlapLeft.TabIndex = 6;
            this.tabPageFlapLeft.Text = "Left Flap";
            this.tabPageFlapLeft.UseVisualStyleBackColor = true;
            // 
            // imageBoxFlapLeft
            // 
            this.imageBoxFlapLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxFlapLeft.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBoxFlapLeft.Location = new System.Drawing.Point(0, 0);
            this.imageBoxFlapLeft.Name = "imageBoxFlapLeft";
            this.imageBoxFlapLeft.Size = new System.Drawing.Size(661, 572);
            this.imageBoxFlapLeft.TabIndex = 2;
            this.imageBoxFlapLeft.TabStop = false;
            // 
            // tabPageFlapRight
            // 
            this.tabPageFlapRight.Controls.Add(this.imageBoxFlapRight);
            this.tabPageFlapRight.Location = new System.Drawing.Point(4, 22);
            this.tabPageFlapRight.Name = "tabPageFlapRight";
            this.tabPageFlapRight.Size = new System.Drawing.Size(661, 572);
            this.tabPageFlapRight.TabIndex = 7;
            this.tabPageFlapRight.Text = "Right Flap";
            this.tabPageFlapRight.UseVisualStyleBackColor = true;
            // 
            // imageBoxFlapRight
            // 
            this.imageBoxFlapRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxFlapRight.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBoxFlapRight.Location = new System.Drawing.Point(0, 0);
            this.imageBoxFlapRight.Name = "imageBoxFlapRight";
            this.imageBoxFlapRight.Size = new System.Drawing.Size(661, 572);
            this.imageBoxFlapRight.TabIndex = 2;
            this.imageBoxFlapRight.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.PreviewImage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MappedPreview, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(946, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(300, 598);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // PreviewImage
            // 
            this.PreviewImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PreviewImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewImage.Location = new System.Drawing.Point(3, 3);
            this.PreviewImage.Name = "PreviewImage";
            this.PreviewImage.Size = new System.Drawing.Size(294, 198);
            this.PreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviewImage.TabIndex = 2;
            this.PreviewImage.TabStop = false;
            this.PreviewImage.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.PreviewImage_LoadCompleted);
            // 
            // MappedPreview
            // 
            this.MappedPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MappedPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MappedPreview.Location = new System.Drawing.Point(3, 207);
            this.MappedPreview.Name = "MappedPreview";
            this.MappedPreview.Size = new System.Drawing.Size(294, 198);
            this.MappedPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MappedPreview.TabIndex = 2;
            this.MappedPreview.TabStop = false;
            // 
            // MainBoxTextureEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainBoxTextureEditForm";
            this.Text = "3D Game Box Maker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControlSides.ResumeLayout(false);
            this.tabPageFront.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFront)).EndInit();
            this.tabPageBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxBack)).EndInit();
            this.tabPageLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLeft)).EndInit();
            this.tabPageRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxRight)).EndInit();
            this.tabPageTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxTop)).EndInit();
            this.tabPageBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxBottom)).EndInit();
            this.tabPageFlapLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFlapLeft)).EndInit();
            this.tabPageFlapRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFlapRight)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MappedPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabControl tabControlSides;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Emgu.CV.UI.ImageBox PreviewImage;
        private Emgu.CV.UI.ImageBox MappedPreview;
        private System.Windows.Forms.TabPage tabPageFront;
        private System.Windows.Forms.TabPage tabPageBack;
        private Emgu.CV.UI.ImageBox imageBoxFront;
        private Emgu.CV.UI.ImageBox imageBoxBack;
        private System.Windows.Forms.TabPage tabPageLeft;
        private Emgu.CV.UI.ImageBox imageBoxLeft;
        private System.Windows.Forms.TabPage tabPageRight;
        private Emgu.CV.UI.ImageBox imageBoxRight;
        private System.Windows.Forms.TabPage tabPageTop;
        private Emgu.CV.UI.ImageBox imageBoxTop;
        private System.Windows.Forms.TabPage tabPageBottom;
        private Emgu.CV.UI.ImageBox imageBoxBottom;
        private System.Windows.Forms.TabPage tabPageFlapLeft;
        private Emgu.CV.UI.ImageBox imageBoxFlapLeft;
        private System.Windows.Forms.TabPage tabPageFlapRight;
        private Emgu.CV.UI.ImageBox imageBoxFlapRight;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem openFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton buttonGuess;
    }
}