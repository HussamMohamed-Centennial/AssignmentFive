namespace AssignmentFive
{
    partial class ProductionForm
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
            this.ProductionFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Product_ID_Label = new System.Windows.Forms.Label();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.manuTextBox = new System.Windows.Forms.TextBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.ManfLabel = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.TechGroupBox = new System.Windows.Forms.GroupBox();
            this.WebCamTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedTextBox = new System.Windows.Forms.TextBox();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.GPUType_label = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.LCDSizeTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.BrandTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.LCDSize = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.MemoryTexBox = new System.Windows.Forms.TextBox();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.ProductionFormLabel = new System.Windows.Forms.Label();
            this.SelectAnothorProductButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ProductSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ProductsopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProductionFormMenuStrip.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductionFormMenuStrip
            // 
            this.ProductionFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.ProductionFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductionFormMenuStrip.Name = "ProductionFormMenuStrip";
            this.ProductionFormMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.ProductionFormMenuStrip.TabIndex = 0;
            this.ProductionFormMenuStrip.Text = "ProductionFormMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.selectAnotherProductToolStripMenuItem.Text = "Select Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.SelectAnothorProductButton_Click);
            // 
            // Product_ID_Label
            // 
            this.Product_ID_Label.AutoSize = true;
            this.Product_ID_Label.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_ID_Label.Location = new System.Drawing.Point(52, 52);
            this.Product_ID_Label.Name = "Product_ID_Label";
            this.Product_ID_Label.Size = new System.Drawing.Size(71, 17);
            this.Product_ID_Label.TabIndex = 1;
            this.Product_ID_Label.Text = "Product ID";
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.Location = new System.Drawing.Point(122, 50);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductIDTextBox.TabIndex = 20;
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Location = new System.Drawing.Point(337, 50);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConditionTextBox.TabIndex = 21;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.Location = new System.Drawing.Point(273, 52);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(66, 17);
            this.ConditionLabel.TabIndex = 3;
            this.ConditionLabel.Text = "Condition";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(558, 50);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostTextBox.TabIndex = 6;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(521, 53);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(34, 17);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost";
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ModelTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.manuTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManfLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(25, 82);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(735, 83);
            this.ProductInfoGroupBox.TabIndex = 7;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(311, 45);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(401, 20);
            this.ModelTextBox.TabIndex = 8;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(265, 49);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(46, 17);
            this.ModelLabel.TabIndex = 7;
            this.ModelLabel.Text = "Model";
            // 
            // OSTextBox
            // 
            this.OSTextBox.Location = new System.Drawing.Point(311, 19);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.Size = new System.Drawing.Size(401, 20);
            this.OSTextBox.TabIndex = 8;
            // 
            // manuTextBox
            // 
            this.manuTextBox.Location = new System.Drawing.Point(97, 45);
            this.manuTextBox.Name = "manuTextBox";
            this.manuTextBox.Size = new System.Drawing.Size(100, 20);
            this.manuTextBox.TabIndex = 6;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSLabel.Location = new System.Drawing.Point(281, 23);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(24, 17);
            this.OSLabel.TabIndex = 7;
            this.OSLabel.Text = "OS";
            // 
            // ManfLabel
            // 
            this.ManfLabel.AutoSize = true;
            this.ManfLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManfLabel.Location = new System.Drawing.Point(20, 49);
            this.ManfLabel.Name = "ManfLabel";
            this.ManfLabel.Size = new System.Drawing.Size(90, 17);
            this.ManfLabel.TabIndex = 5;
            this.ManfLabel.Text = "Manufacturer";
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Location = new System.Drawing.Point(97, 19);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlatformTextBox.TabIndex = 6;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformLabel.Location = new System.Drawing.Point(45, 23);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(58, 17);
            this.PlatformLabel.TabIndex = 5;
            this.PlatformLabel.Text = "Platform";
            // 
            // TechGroupBox
            // 
            this.TechGroupBox.Controls.Add(this.WebCamTextBox);
            this.TechGroupBox.Controls.Add(this.TypeTextBox);
            this.TechGroupBox.Controls.Add(this.HDDTextBox);
            this.TechGroupBox.Controls.Add(this.CPUSpeedTextBox);
            this.TechGroupBox.Controls.Add(this.WebCamLabel);
            this.TechGroupBox.Controls.Add(this.NumberTextBox);
            this.TechGroupBox.Controls.Add(this.GPUType_label);
            this.TechGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.TechGroupBox.Controls.Add(this.LCDSizeTextBox);
            this.TechGroupBox.Controls.Add(this.CPUNumberLabel);
            this.TechGroupBox.Controls.Add(this.CPUTypeTextBox);
            this.TechGroupBox.Controls.Add(this.HDDLabel);
            this.TechGroupBox.Controls.Add(this.BrandTextBox);
            this.TechGroupBox.Controls.Add(this.CPUTypeLabel);
            this.TechGroupBox.Controls.Add(this.LCDSize);
            this.TechGroupBox.Controls.Add(this.CPUBrandLabel);
            this.TechGroupBox.Controls.Add(this.MemoryTexBox);
            this.TechGroupBox.Controls.Add(this.MemoryLabel);
            this.TechGroupBox.Location = new System.Drawing.Point(25, 180);
            this.TechGroupBox.Name = "TechGroupBox";
            this.TechGroupBox.Size = new System.Drawing.Size(735, 106);
            this.TechGroupBox.TabIndex = 7;
            this.TechGroupBox.TabStop = false;
            this.TechGroupBox.Text = "Tech Specs";
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.Location = new System.Drawing.Point(533, 68);
            this.WebCamTextBox.Name = "WebCamTextBox";
            this.WebCamTextBox.Size = new System.Drawing.Size(179, 20);
            this.WebCamTextBox.TabIndex = 8;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(533, 42);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(179, 20);
            this.TypeTextBox.TabIndex = 8;
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.Location = new System.Drawing.Point(533, 16);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.Size = new System.Drawing.Size(179, 20);
            this.HDDTextBox.TabIndex = 8;
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(311, 71);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(101, 20);
            this.CPUSpeedTextBox.TabIndex = 8;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebCamLabel.Location = new System.Drawing.Point(469, 72);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(61, 17);
            this.WebCamLabel.TabIndex = 7;
            this.WebCamLabel.Text = "WebCam";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(311, 45);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(101, 20);
            this.NumberTextBox.TabIndex = 8;
            // 
            // GPUType_label
            // 
            this.GPUType_label.AutoSize = true;
            this.GPUType_label.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUType_label.Location = new System.Drawing.Point(467, 46);
            this.GPUType_label.Name = "GPUType_label";
            this.GPUType_label.Size = new System.Drawing.Size(65, 17);
            this.GPUType_label.TabIndex = 7;
            this.GPUType_label.Text = "GPU Type";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedLabel.Location = new System.Drawing.Point(240, 75);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(70, 17);
            this.CPUSpeedLabel.TabIndex = 7;
            this.CPUSpeedLabel.Text = "CPU speed";
            // 
            // LCDSizeTextBox
            // 
            this.LCDSizeTextBox.Location = new System.Drawing.Point(311, 19);
            this.LCDSizeTextBox.Name = "LCDSizeTextBox";
            this.LCDSizeTextBox.Size = new System.Drawing.Size(101, 20);
            this.LCDSizeTextBox.TabIndex = 8;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNumberLabel.Location = new System.Drawing.Point(230, 49);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(81, 17);
            this.CPUNumberLabel.TabIndex = 7;
            this.CPUNumberLabel.Text = "CPU number";
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.Location = new System.Drawing.Point(97, 71);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.CPUTypeTextBox.TabIndex = 6;
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDLabel.Location = new System.Drawing.Point(493, 20);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(35, 17);
            this.HDDLabel.TabIndex = 7;
            this.HDDLabel.Text = "HDD";
            // 
            // BrandTextBox
            // 
            this.BrandTextBox.Location = new System.Drawing.Point(97, 45);
            this.BrandTextBox.Name = "BrandTextBox";
            this.BrandTextBox.Size = new System.Drawing.Size(100, 20);
            this.BrandTextBox.TabIndex = 6;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeLabel.Location = new System.Drawing.Point(33, 75);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(63, 17);
            this.CPUTypeLabel.TabIndex = 5;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // LCDSize
            // 
            this.LCDSize.AutoSize = true;
            this.LCDSize.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDSize.Location = new System.Drawing.Point(252, 23);
            this.LCDSize.Name = "LCDSize";
            this.LCDSize.Size = new System.Drawing.Size(56, 17);
            this.LCDSize.TabIndex = 7;
            this.LCDSize.Text = "LCD Size";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandLabel.Location = new System.Drawing.Point(27, 49);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(70, 17);
            this.CPUBrandLabel.TabIndex = 5;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // MemoryTexBox
            // 
            this.MemoryTexBox.Location = new System.Drawing.Point(97, 19);
            this.MemoryTexBox.Name = "MemoryTexBox";
            this.MemoryTexBox.Size = new System.Drawing.Size(100, 20);
            this.MemoryTexBox.TabIndex = 6;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.Location = new System.Drawing.Point(39, 23);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(58, 17);
            this.MemoryLabel.TabIndex = 5;
            this.MemoryLabel.Text = "Memory";
            // 
            // ProductionFormLabel
            // 
            this.ProductionFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductionFormLabel.Location = new System.Drawing.Point(31, 308);
            this.ProductionFormLabel.Name = "ProductionFormLabel";
            this.ProductionFormLabel.Size = new System.Drawing.Size(373, 29);
            this.ProductionFormLabel.TabIndex = 8;
            this.ProductionFormLabel.Text = "Click Next to Confirm Your Selection";
            // 
            // SelectAnothorProductButton
            // 
            this.SelectAnothorProductButton.Location = new System.Drawing.Point(464, 398);
            this.SelectAnothorProductButton.Name = "SelectAnothorProductButton";
            this.SelectAnothorProductButton.Size = new System.Drawing.Size(131, 29);
            this.SelectAnothorProductButton.TabIndex = 9;
            this.SelectAnothorProductButton.Text = "Select Another Product";
            this.SelectAnothorProductButton.UseVisualStyleBackColor = true;
            this.SelectAnothorProductButton.Click += new System.EventHandler(this.SelectAnothorProductButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(606, 398);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(74, 29);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(686, 398);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(74, 29);
            this.NextButton.TabIndex = 9;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ProductSaveFileDialog
            // 
            this.ProductSaveFileDialog.DefaultExt = "txt";
            this.ProductSaveFileDialog.FileName = "Product";
            this.ProductSaveFileDialog.Filter = "text files|*.txt|All filles|*.*";
            // 
            // ProductsopenFileDialog
            // 
            this.ProductsopenFileDialog.DefaultExt = "txt";
            this.ProductsopenFileDialog.FileName = "Product";
            this.ProductsopenFileDialog.Filter = "Text filles|*.txt|All Filles|*.*";
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectAnothorProductButton);
            this.Controls.Add(this.ProductionFormLabel);
            this.Controls.Add(this.TechGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.Product_ID_Label);
            this.Controls.Add(this.ProductionFormMenuStrip);
            this.MainMenuStrip = this.ProductionFormMenuStrip;
            this.Name = "ProductionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductionForm";
            this.Activated += new System.EventHandler(this.ProductionForm_Activated);
            this.Load += new System.EventHandler(this.ProductionForm_Load);
            this.ProductionFormMenuStrip.ResumeLayout(false);
            this.ProductionFormMenuStrip.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechGroupBox.ResumeLayout(false);
            this.TechGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ProductionFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Label Product_ID_Label;
        private System.Windows.Forms.TextBox ProductIDTextBox;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.TextBox manuTextBox;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label ManfLabel;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.GroupBox TechGroupBox;
        private System.Windows.Forms.TextBox WebCamTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.TextBox CPUSpeedTextBox;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Label GPUType_label;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.TextBox LCDSizeTextBox;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.TextBox CPUTypeTextBox;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label LCDSize;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.TextBox MemoryTexBox;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label ProductionFormLabel;
        private System.Windows.Forms.Button SelectAnothorProductButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SaveFileDialog ProductSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog ProductsopenFileDialog;
    }
}