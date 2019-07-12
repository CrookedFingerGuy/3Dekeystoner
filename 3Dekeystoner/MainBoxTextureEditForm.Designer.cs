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
            this.exportTexturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cVStepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.buttonGuess = new System.Windows.Forms.ToolStripButton();
            this.toolStripCBProjectType = new System.Windows.Forms.ToolStripComboBox();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMirrorVertical = new System.Windows.Forms.Button();
            this.btnMirrorHorizontal = new System.Windows.Forms.Button();
            this.btnRotateCCW = new System.Windows.Forms.Button();
            this.btnRotateCW = new System.Windows.Forms.Button();
            this.about3DekeystomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.debugToolStripMenuItem});
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
            this.exportTexturesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFilesToolStripMenuItem
            // 
            this.openFilesToolStripMenuItem.Name = "openFilesToolStripMenuItem";
            this.openFilesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.openFilesToolStripMenuItem.Text = "Open Files... ";
            this.openFilesToolStripMenuItem.Click += new System.EventHandler(this.openFilesToolStripMenuItem_Click);
            // 
            // exportTexturesToolStripMenuItem
            // 
            this.exportTexturesToolStripMenuItem.Name = "exportTexturesToolStripMenuItem";
            this.exportTexturesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exportTexturesToolStripMenuItem.Text = "Export Textures...";
            this.exportTexturesToolStripMenuItem.Click += new System.EventHandler(this.exportTexturesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about3DekeystomerToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cVStepsToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.debugToolStripMenuItem.Text = "Debug...";
            // 
            // cVStepsToolStripMenuItem
            // 
            this.cVStepsToolStripMenuItem.Name = "cVStepsToolStripMenuItem";
            this.cVStepsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.cVStepsToolStripMenuItem.Text = "CV Steps";
            this.cVStepsToolStripMenuItem.Click += new System.EventHandler(this.cVStepsToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.buttonGuess,
            this.toolStripCBProjectType});
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
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "Assign";
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
            // toolStripCBProjectType
            // 
            this.toolStripCBProjectType.DropDownWidth = 250;
            this.toolStripCBProjectType.Items.AddRange(new object[] {
            "Small PC Box With Flap (5.25\"x7.5\"x1.25\")",
            "Small PC Box (5.25\"x7.5\"x1.25\")"});
            this.toolStripCBProjectType.Name = "toolStripCBProjectType";
            this.toolStripCBProjectType.Size = new System.Drawing.Size(250, 25);
            this.toolStripCBProjectType.SelectedIndexChanged += new System.EventHandler(this.toolStripCBProjectType_SelectedIndexChanged);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 325F));
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
            this.listView1.Size = new System.Drawing.Size(248, 598);
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
            this.tabControlSides.Location = new System.Drawing.Point(263, 6);
            this.tabControlSides.Name = "tabControlSides";
            this.tabControlSides.SelectedIndex = 0;
            this.tabControlSides.Size = new System.Drawing.Size(654, 598);
            this.tabControlSides.TabIndex = 1;
            this.tabControlSides.SelectedIndexChanged += new System.EventHandler(this.tabControlSides_SelectedIndexChanged);
            // 
            // tabPageFront
            // 
            this.tabPageFront.Controls.Add(this.imageBoxFront);
            this.tabPageFront.Location = new System.Drawing.Point(4, 22);
            this.tabPageFront.Name = "tabPageFront";
            this.tabPageFront.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFront.Size = new System.Drawing.Size(646, 572);
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
            this.imageBoxFront.Size = new System.Drawing.Size(640, 566);
            this.imageBoxFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxFront.TabIndex = 2;
            this.imageBoxFront.TabStop = false;
            this.imageBoxFront.DragDrop += new System.Windows.Forms.DragEventHandler(this.imageBoxFront_DragDrop);
            this.imageBoxFront.DragEnter += new System.Windows.Forms.DragEventHandler(this.imageBox_DragEnter);
            this.imageBoxFront.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBox_Paint);
            this.imageBoxFront.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseDown);
            this.imageBoxFront.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseMove);
            this.imageBoxFront.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseUp);
            // 
            // tabPageBack
            // 
            this.tabPageBack.Controls.Add(this.imageBoxBack);
            this.tabPageBack.Location = new System.Drawing.Point(4, 22);
            this.tabPageBack.Name = "tabPageBack";
            this.tabPageBack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBack.Size = new System.Drawing.Size(646, 572);
            this.tabPageBack.TabIndex = 1;
            this.tabPageBack.Text = "Back";
            this.tabPageBack.UseVisualStyleBackColor = true;
            // 
            // imageBoxBack
            // 
            this.imageBoxBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxBack.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBoxBack.Location = new System.Drawing.Point(3, 3);
            this.imageBoxBack.Name = "imageBoxBack";
            this.imageBoxBack.Size = new System.Drawing.Size(640, 566);
            this.imageBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxBack.TabIndex = 2;
            this.imageBoxBack.TabStop = false;
            this.imageBoxBack.DragDrop += new System.Windows.Forms.DragEventHandler(this.imageBoxBack_DragDrop);
            this.imageBoxBack.DragEnter += new System.Windows.Forms.DragEventHandler(this.imageBox_DragEnter);
            this.imageBoxBack.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBox_Paint);
            this.imageBoxBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseDown);
            this.imageBoxBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseMove);
            this.imageBoxBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseUp);
            // 
            // tabPageLeft
            // 
            this.tabPageLeft.Controls.Add(this.imageBoxLeft);
            this.tabPageLeft.Location = new System.Drawing.Point(4, 22);
            this.tabPageLeft.Name = "tabPageLeft";
            this.tabPageLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPageLeft.Size = new System.Drawing.Size(646, 572);
            this.tabPageLeft.TabIndex = 2;
            this.tabPageLeft.Text = "Left Side";
            this.tabPageLeft.UseVisualStyleBackColor = true;
            // 
            // imageBoxLeft
            // 
            this.imageBoxLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxLeft.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBoxLeft.Location = new System.Drawing.Point(0, 0);
            this.imageBoxLeft.Name = "imageBoxLeft";
            this.imageBoxLeft.Size = new System.Drawing.Size(646, 572);
            this.imageBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxLeft.TabIndex = 2;
            this.imageBoxLeft.TabStop = false;
            this.imageBoxLeft.DragDrop += new System.Windows.Forms.DragEventHandler(this.imageBoxLeft_DragDrop);
            this.imageBoxLeft.DragEnter += new System.Windows.Forms.DragEventHandler(this.imageBox_DragEnter);
            this.imageBoxLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBox_Paint);
            this.imageBoxLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseDown);
            this.imageBoxLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseMove);
            this.imageBoxLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseUp);
            // 
            // tabPageRight
            // 
            this.tabPageRight.Controls.Add(this.imageBoxRight);
            this.tabPageRight.Location = new System.Drawing.Point(4, 22);
            this.tabPageRight.Name = "tabPageRight";
            this.tabPageRight.Size = new System.Drawing.Size(646, 572);
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
            this.imageBoxRight.Size = new System.Drawing.Size(646, 572);
            this.imageBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxRight.TabIndex = 2;
            this.imageBoxRight.TabStop = false;
            this.imageBoxRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.imageBoxRight_DragDrop);
            this.imageBoxRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.imageBox_DragEnter);
            this.imageBoxRight.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBox_Paint);
            this.imageBoxRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseDown);
            this.imageBoxRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseMove);
            this.imageBoxRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseUp);
            // 
            // tabPageTop
            // 
            this.tabPageTop.Controls.Add(this.imageBoxTop);
            this.tabPageTop.Location = new System.Drawing.Point(4, 22);
            this.tabPageTop.Name = "tabPageTop";
            this.tabPageTop.Size = new System.Drawing.Size(646, 572);
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
            this.imageBoxTop.Size = new System.Drawing.Size(646, 572);
            this.imageBoxTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxTop.TabIndex = 2;
            this.imageBoxTop.TabStop = false;
            this.imageBoxTop.DragDrop += new System.Windows.Forms.DragEventHandler(this.imageBoxTop_DragDrop);
            this.imageBoxTop.DragEnter += new System.Windows.Forms.DragEventHandler(this.imageBox_DragEnter);
            this.imageBoxTop.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBox_Paint);
            this.imageBoxTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseDown);
            this.imageBoxTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseMove);
            this.imageBoxTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseUp);
            // 
            // tabPageBottom
            // 
            this.tabPageBottom.Controls.Add(this.imageBoxBottom);
            this.tabPageBottom.Location = new System.Drawing.Point(4, 22);
            this.tabPageBottom.Name = "tabPageBottom";
            this.tabPageBottom.Size = new System.Drawing.Size(646, 572);
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
            this.imageBoxBottom.Size = new System.Drawing.Size(646, 572);
            this.imageBoxBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxBottom.TabIndex = 2;
            this.imageBoxBottom.TabStop = false;
            this.imageBoxBottom.DragDrop += new System.Windows.Forms.DragEventHandler(this.imageBoxBottom_DragDrop);
            this.imageBoxBottom.DragEnter += new System.Windows.Forms.DragEventHandler(this.imageBox_DragEnter);
            this.imageBoxBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBox_Paint);
            this.imageBoxBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseDown);
            this.imageBoxBottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseMove);
            this.imageBoxBottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseUp);
            // 
            // tabPageFlapLeft
            // 
            this.tabPageFlapLeft.Controls.Add(this.imageBoxFlapLeft);
            this.tabPageFlapLeft.Location = new System.Drawing.Point(4, 22);
            this.tabPageFlapLeft.Name = "tabPageFlapLeft";
            this.tabPageFlapLeft.Size = new System.Drawing.Size(646, 572);
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
            this.imageBoxFlapLeft.Size = new System.Drawing.Size(646, 572);
            this.imageBoxFlapLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxFlapLeft.TabIndex = 2;
            this.imageBoxFlapLeft.TabStop = false;
            this.imageBoxFlapLeft.DragDrop += new System.Windows.Forms.DragEventHandler(this.imageBoxFlapLeft_DragDrop);
            this.imageBoxFlapLeft.DragEnter += new System.Windows.Forms.DragEventHandler(this.imageBox_DragEnter);
            this.imageBoxFlapLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBox_Paint);
            this.imageBoxFlapLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseDown);
            this.imageBoxFlapLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseMove);
            this.imageBoxFlapLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseUp);
            // 
            // tabPageFlapRight
            // 
            this.tabPageFlapRight.Controls.Add(this.imageBoxFlapRight);
            this.tabPageFlapRight.Location = new System.Drawing.Point(4, 22);
            this.tabPageFlapRight.Name = "tabPageFlapRight";
            this.tabPageFlapRight.Size = new System.Drawing.Size(646, 572);
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
            this.imageBoxFlapRight.Size = new System.Drawing.Size(646, 572);
            this.imageBoxFlapRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxFlapRight.TabIndex = 2;
            this.imageBoxFlapRight.TabStop = false;
            this.imageBoxFlapRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.imageBoxFlapRight_DragDrop);
            this.imageBoxFlapRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.imageBox_DragEnter);
            this.imageBoxFlapRight.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBox_Paint);
            this.imageBoxFlapRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseDown);
            this.imageBoxFlapRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseMove);
            this.imageBoxFlapRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseUp);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.PreviewImage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MappedPreview, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(926, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(320, 598);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // PreviewImage
            // 
            this.PreviewImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PreviewImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewImage.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.PreviewImage.Location = new System.Drawing.Point(3, 3);
            this.PreviewImage.Name = "PreviewImage";
            this.PreviewImage.Size = new System.Drawing.Size(314, 198);
            this.PreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviewImage.TabIndex = 2;
            this.PreviewImage.TabStop = false;
            this.PreviewImage.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.PreviewImage_LoadCompleted);
            // 
            // MappedPreview
            // 
            this.MappedPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MappedPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MappedPreview.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.MappedPreview.Location = new System.Drawing.Point(3, 207);
            this.MappedPreview.Name = "MappedPreview";
            this.MappedPreview.Size = new System.Drawing.Size(314, 198);
            this.MappedPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MappedPreview.TabIndex = 2;
            this.MappedPreview.TabStop = false;
            this.MappedPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.MappedPreview_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnMirrorVertical);
            this.panel1.Controls.Add(this.btnMirrorHorizontal);
            this.panel1.Controls.Add(this.btnRotateCCW);
            this.panel1.Controls.Add(this.btnRotateCW);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 184);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::_3Dekeystoner.Properties.Resources.IconRotate180;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(85, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMirrorVertical
            // 
            this.btnMirrorVertical.BackgroundImage = global::_3Dekeystoner.Properties.Resources.IconMirrorVer;
            this.btnMirrorVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMirrorVertical.Location = new System.Drawing.Point(44, 44);
            this.btnMirrorVertical.Name = "btnMirrorVertical";
            this.btnMirrorVertical.Size = new System.Drawing.Size(35, 35);
            this.btnMirrorVertical.TabIndex = 7;
            this.btnMirrorVertical.UseVisualStyleBackColor = true;
            this.btnMirrorVertical.Click += new System.EventHandler(this.btnMirrorVertical_Click);
            // 
            // btnMirrorHorizontal
            // 
            this.btnMirrorHorizontal.BackgroundImage = global::_3Dekeystoner.Properties.Resources.IconMirrorHor;
            this.btnMirrorHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMirrorHorizontal.Location = new System.Drawing.Point(3, 44);
            this.btnMirrorHorizontal.Name = "btnMirrorHorizontal";
            this.btnMirrorHorizontal.Size = new System.Drawing.Size(35, 35);
            this.btnMirrorHorizontal.TabIndex = 6;
            this.btnMirrorHorizontal.UseVisualStyleBackColor = true;
            this.btnMirrorHorizontal.Click += new System.EventHandler(this.btnMirrorHorizontal_Click);
            // 
            // btnRotateCCW
            // 
            this.btnRotateCCW.BackgroundImage = global::_3Dekeystoner.Properties.Resources.IconRotateCCW;
            this.btnRotateCCW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRotateCCW.Location = new System.Drawing.Point(44, 3);
            this.btnRotateCCW.Name = "btnRotateCCW";
            this.btnRotateCCW.Size = new System.Drawing.Size(35, 35);
            this.btnRotateCCW.TabIndex = 5;
            this.btnRotateCCW.UseVisualStyleBackColor = true;
            this.btnRotateCCW.Click += new System.EventHandler(this.btnRotateCCW_Click);
            // 
            // btnRotateCW
            // 
            this.btnRotateCW.BackgroundImage = global::_3Dekeystoner.Properties.Resources.IconRotateCW;
            this.btnRotateCW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRotateCW.Location = new System.Drawing.Point(3, 3);
            this.btnRotateCW.Name = "btnRotateCW";
            this.btnRotateCW.Size = new System.Drawing.Size(35, 35);
            this.btnRotateCW.TabIndex = 4;
            this.btnRotateCW.UseVisualStyleBackColor = true;
            this.btnRotateCW.Click += new System.EventHandler(this.btnRotateCW_Click);
            // 
            // about3DekeystomerToolStripMenuItem
            // 
            this.about3DekeystomerToolStripMenuItem.Name = "about3DekeystomerToolStripMenuItem";
            this.about3DekeystomerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.about3DekeystomerToolStripMenuItem.Text = "About 3Dekeystoner...";
            this.about3DekeystomerToolStripMenuItem.Click += new System.EventHandler(this.about3DekeystomerToolStripMenuItem_Click);
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
            this.panel1.ResumeLayout(false);
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
        public System.Windows.Forms.TabControl tabControlSides;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public Emgu.CV.UI.ImageBox PreviewImage;
        public Emgu.CV.UI.ImageBox MappedPreview;
        public System.Windows.Forms.TabPage tabPageFront;
        public System.Windows.Forms.TabPage tabPageBack;
        public Emgu.CV.UI.ImageBox imageBoxFront;
        public Emgu.CV.UI.ImageBox imageBoxBack;
        public System.Windows.Forms.TabPage tabPageLeft;
        public Emgu.CV.UI.ImageBox imageBoxLeft;
        public System.Windows.Forms.TabPage tabPageRight;
        public Emgu.CV.UI.ImageBox imageBoxRight;
        public System.Windows.Forms.TabPage tabPageTop;
        public Emgu.CV.UI.ImageBox imageBoxTop;
        public System.Windows.Forms.TabPage tabPageBottom;
        public Emgu.CV.UI.ImageBox imageBoxBottom;
        public System.Windows.Forms.TabPage tabPageFlapLeft;
        public Emgu.CV.UI.ImageBox imageBoxFlapLeft;
        public System.Windows.Forms.TabPage tabPageFlapRight;
        public Emgu.CV.UI.ImageBox imageBoxFlapRight;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem openFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton buttonGuess;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cVStepsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRotateCCW;
        private System.Windows.Forms.Button btnRotateCW;
        private System.Windows.Forms.ToolStripMenuItem exportTexturesToolStripMenuItem;
        private System.Windows.Forms.Button btnMirrorVertical;
        private System.Windows.Forms.Button btnMirrorHorizontal;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ToolStripComboBox toolStripCBProjectType;
        private System.Windows.Forms.ToolStripMenuItem about3DekeystomerToolStripMenuItem;
    }
}