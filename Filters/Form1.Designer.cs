namespace Filters
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.failToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaLeFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brigtnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wave1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cдвигToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearStretchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стеклоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резкость = new System.Windows.Forms.ToolStripMenuItem();
            this.sharFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prewittFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathMorfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editKernelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expansionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Cancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Undo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(54, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.failToolStripMenuItem,
            this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // failToolStripMenuItem
            // 
            this.failToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.failToolStripMenuItem.Name = "failToolStripMenuItem";
            this.failToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.failToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveAsToolStripMenuItem.Text = "Сохранить";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointableToolStripMenuItem,
            this.matrixToolStripMenuItem,
            this.mathMorfToolStripMenuItem,
            this.expansionToolStripMenuItem,
            this.дополнительноToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.filtersToolStripMenuItem.Text = "Фильтры";
            // 
            // pointableToolStripMenuItem
            // 
            this.pointableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inversionToolStripMenuItem,
            this.grayScaLeFilterToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.brigtnessToolStripMenuItem,
            this.wave1ToolStripMenuItem,
            this.transferToolStripMenuItem,
            this.linearStretchingToolStripMenuItem,
            this.grayColorToolStripMenuItem,
            this.стеклоToolStripMenuItem});
            this.pointableToolStripMenuItem.Name = "pointableToolStripMenuItem";
            this.pointableToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.pointableToolStripMenuItem.Text = "Точечные";
            // 
            // inversionToolStripMenuItem
            // 
            this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            this.inversionToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.inversionToolStripMenuItem.Text = "Инверсия";
            this.inversionToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
            // 
            // grayScaLeFilterToolStripMenuItem
            // 
            this.grayScaLeFilterToolStripMenuItem.Name = "grayScaLeFilterToolStripMenuItem";
            this.grayScaLeFilterToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.grayScaLeFilterToolStripMenuItem.Text = "Черно-Белое";
            this.grayScaLeFilterToolStripMenuItem.Click += new System.EventHandler(this.grayScaLeFilterToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.sepiaToolStripMenuItem.Text = "Сепия";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // brigtnessToolStripMenuItem
            // 
            this.brigtnessToolStripMenuItem.Name = "brigtnessToolStripMenuItem";
            this.brigtnessToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.brigtnessToolStripMenuItem.Text = "Яркость";
            this.brigtnessToolStripMenuItem.Click += new System.EventHandler(this.brigtnessToolStripMenuItem_Click);
            // 
            // wave1ToolStripMenuItem
            // 
            this.wave1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вертикальнаяToolStripMenuItem,
            this.горизонтальнаяToolStripMenuItem});
            this.wave1ToolStripMenuItem.Name = "wave1ToolStripMenuItem";
            this.wave1ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.wave1ToolStripMenuItem.Text = "Волна";
            this.wave1ToolStripMenuItem.Click += new System.EventHandler(this.wave1ToolStripMenuItem_Click);
            // 
            // вертикальнаяToolStripMenuItem
            // 
            this.вертикальнаяToolStripMenuItem.Name = "вертикальнаяToolStripMenuItem";
            this.вертикальнаяToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.вертикальнаяToolStripMenuItem.Text = "Вертикальная";
            this.вертикальнаяToolStripMenuItem.Click += new System.EventHandler(this.вертикальнаяToolStripMenuItem_Click);
            // 
            // горизонтальнаяToolStripMenuItem
            // 
            this.горизонтальнаяToolStripMenuItem.Name = "горизонтальнаяToolStripMenuItem";
            this.горизонтальнаяToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.горизонтальнаяToolStripMenuItem.Text = "Горизонтальная";
            this.горизонтальнаяToolStripMenuItem.Click += new System.EventHandler(this.горизонтальнаяToolStripMenuItem_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поворотToolStripMenuItem,
            this.cдвигToolStripMenuItem});
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.transferToolStripMenuItem.Text = "Сдвиг";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // поворотToolStripMenuItem
            // 
            this.поворотToolStripMenuItem.Name = "поворотToolStripMenuItem";
            this.поворотToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.поворотToolStripMenuItem.Text = "Поворот";
            this.поворотToolStripMenuItem.Click += new System.EventHandler(this.поворотToolStripMenuItem_Click);
            // 
            // cдвигToolStripMenuItem
            // 
            this.cдвигToolStripMenuItem.Name = "cдвигToolStripMenuItem";
            this.cдвигToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cдвигToolStripMenuItem.Text = "Cдвиг";
            this.cдвигToolStripMenuItem.Click += new System.EventHandler(this.cдвигToolStripMenuItem_Click);
            // 
            // linearStretchingToolStripMenuItem
            // 
            this.linearStretchingToolStripMenuItem.Name = "linearStretchingToolStripMenuItem";
            this.linearStretchingToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.linearStretchingToolStripMenuItem.Text = "Линейное растяжение";
            this.linearStretchingToolStripMenuItem.Click += new System.EventHandler(this.linearStretchingToolStripMenuItem_Click);
            // 
            // grayColorToolStripMenuItem
            // 
            this.grayColorToolStripMenuItem.Name = "grayColorToolStripMenuItem";
            this.grayColorToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.grayColorToolStripMenuItem.Text = "\"Серый мир\"";
            this.grayColorToolStripMenuItem.Click += new System.EventHandler(this.grayColorToolStripMenuItem_Click);
            // 
            // стеклоToolStripMenuItem
            // 
            this.стеклоToolStripMenuItem.Name = "стеклоToolStripMenuItem";
            this.стеклоToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.стеклоToolStripMenuItem.Text = "Стекло";
            this.стеклоToolStripMenuItem.Click += new System.EventHandler(this.стеклоToolStripMenuItem_Click);
            // 
            // matrixToolStripMenuItem
            // 
            this.matrixToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurringToolStripMenuItem,
            this.gaussFilterToolStripMenuItem,
            this.sobelFilterToolStripMenuItem,
            this.резкость,
            this.sharFilterToolStripMenuItem,
            this.prewittFilterToolStripMenuItem,
            this.medianFilterToolStripMenuItem,
            this.размытостьToolStripMenuItem});
            this.matrixToolStripMenuItem.Name = "matrixToolStripMenuItem";
            this.matrixToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.matrixToolStripMenuItem.Text = "Матричные";
            // 
            // blurringToolStripMenuItem
            // 
            this.blurringToolStripMenuItem.Name = "blurringToolStripMenuItem";
            this.blurringToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.blurringToolStripMenuItem.Text = "Размытость";
            this.blurringToolStripMenuItem.Click += new System.EventHandler(this.blurringToolStripMenuItem_Click);
            // 
            // gaussFilterToolStripMenuItem
            // 
            this.gaussFilterToolStripMenuItem.Name = "gaussFilterToolStripMenuItem";
            this.gaussFilterToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.gaussFilterToolStripMenuItem.Text = "Фильтр Гаусса";
            this.gaussFilterToolStripMenuItem.Click += new System.EventHandler(this.gaussFilterToolStripMenuItem_Click);
            // 
            // sobelFilterToolStripMenuItem
            // 
            this.sobelFilterToolStripMenuItem.Name = "sobelFilterToolStripMenuItem";
            this.sobelFilterToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.sobelFilterToolStripMenuItem.Text = "Фильтр Собеля";
            this.sobelFilterToolStripMenuItem.Click += new System.EventHandler(this.sobelFilterToolStripMenuItem_Click);
            // 
            // резкость
            // 
            this.резкость.Name = "резкость";
            this.резкость.Size = new System.Drawing.Size(184, 22);
            this.резкость.Text = "Резкость";
            this.резкость.Click += new System.EventHandler(this.sharpnessToolStripMenuItem_Click);
            // 
            // sharFilterToolStripMenuItem
            // 
            this.sharFilterToolStripMenuItem.Name = "sharFilterToolStripMenuItem";
            this.sharFilterToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.sharFilterToolStripMenuItem.Text = "Фильтр Щарра";
            this.sharFilterToolStripMenuItem.Click += new System.EventHandler(this.sharFilterToolStripMenuItem_Click);
            // 
            // prewittFilterToolStripMenuItem
            // 
            this.prewittFilterToolStripMenuItem.Name = "prewittFilterToolStripMenuItem";
            this.prewittFilterToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.prewittFilterToolStripMenuItem.Text = "Фильтр Прюитта";
            this.prewittFilterToolStripMenuItem.Click += new System.EventHandler(this.prewittFilterToolStripMenuItem_Click);
            // 
            // medianFilterToolStripMenuItem
            // 
            this.medianFilterToolStripMenuItem.Name = "medianFilterToolStripMenuItem";
            this.medianFilterToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.medianFilterToolStripMenuItem.Text = "Медианный фильтр";
            this.medianFilterToolStripMenuItem.Click += new System.EventHandler(this.medianFilterToolStripMenuItem_Click);
            // 
            // размытостьToolStripMenuItem
            // 
            this.размытостьToolStripMenuItem.Name = "размытостьToolStripMenuItem";
            this.размытостьToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.размытостьToolStripMenuItem.Text = "MotionBlur";
            this.размытостьToolStripMenuItem.Click += new System.EventHandler(this.размытостьToolStripMenuItem_Click);
            // 
            // mathMorfToolStripMenuItem
            // 
            this.mathMorfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.topHatToolStripMenuItem,
            this.editKernelToolStripMenuItem});
            this.mathMorfToolStripMenuItem.Name = "mathMorfToolStripMenuItem";
            this.mathMorfToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.mathMorfToolStripMenuItem.Text = "Матем морфология";
            this.mathMorfToolStripMenuItem.Click += new System.EventHandler(this.mathMorfToolStripMenuItem_Click);
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.dilationToolStripMenuItem.Text = "Dilation";
            this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.erosionToolStripMenuItem.Text = "Erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.openingToolStripMenuItem.Text = "Opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.closingToolStripMenuItem.Text = "Closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // topHatToolStripMenuItem
            // 
            this.topHatToolStripMenuItem.Name = "topHatToolStripMenuItem";
            this.topHatToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.topHatToolStripMenuItem.Text = "Top Hat";
            this.topHatToolStripMenuItem.Click += new System.EventHandler(this.topHatToolStripMenuItem_Click);
            // 
            // editKernelToolStripMenuItem
            // 
            this.editKernelToolStripMenuItem.Name = "editKernelToolStripMenuItem";
            this.editKernelToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.editKernelToolStripMenuItem.Text = "Edit Kernel";
            this.editKernelToolStripMenuItem.Click += new System.EventHandler(this.editKernelToolStripMenuItem_Click);
            // 
            // expansionToolStripMenuItem
            // 
            this.expansionToolStripMenuItem.Name = "expansionToolStripMenuItem";
            this.expansionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.expansionToolStripMenuItem.Text = "Expansion";
            this.expansionToolStripMenuItem.Click += new System.EventHandler(this.expansionToolStripMenuItem_Click);
            // 
            // дополнительноToolStripMenuItem
            // 
            this.дополнительноToolStripMenuItem.Name = "дополнительноToolStripMenuItem";
            this.дополнительноToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.дополнительноToolStripMenuItem.Text = "дополнительно";
            this.дополнительноToolStripMenuItem.Click += new System.EventHandler(this.дополнительноToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.AutoSize = true;
            this.Cancel.Location = new System.Drawing.Point(644, 408);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(30, 431);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(593, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // Undo
            // 
            this.Undo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Undo.Location = new System.Drawing.Point(644, 452);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(75, 23);
            this.Undo.TabIndex = 4;
            this.Undo.Text = "удалить";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(582, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(227, 222);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(654, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9",
            "11",
            "13",
            "15",
            "17",
            "19",
            "21",
            "23",
            "25"});
            this.comboBox1.Location = new System.Drawing.Point(629, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(984, 518);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem failToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrixToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem blurringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaLeFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brigtnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резкость;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.ToolStripMenuItem wave1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prewittFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mathMorfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem linearStretchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topHatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expansionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стеклоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поворотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикальнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem горизонтальнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cдвигToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editKernelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дополнительноToolStripMenuItem;
    }
}

