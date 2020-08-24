namespace AssignmentFive
{
    partial class OrderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemGroupBox = new System.Windows.Forms.GroupBox();
            this.OS_Label = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDD_Label = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.LCDLabel = new System.Windows.Forms.Label();
            this.BiglistBox = new System.Windows.Forms.ListBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ManuTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ManuLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.CondionLabel = new System.Windows.Forms.Label();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalTexBox = new System.Windows.Forms.TextBox();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SystemGroupBox.SuspendLayout();
            this.PriceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(96, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SystemGroupBox
            // 
            this.SystemGroupBox.Controls.Add(this.OS_Label);
            this.SystemGroupBox.Controls.Add(this.WebCamLabel);
            this.SystemGroupBox.Controls.Add(this.GPUTypeLabel);
            this.SystemGroupBox.Controls.Add(this.HDD_Label);
            this.SystemGroupBox.Controls.Add(this.SpeedLabel);
            this.SystemGroupBox.Controls.Add(this.NumberLabel);
            this.SystemGroupBox.Controls.Add(this.TypeLabel);
            this.SystemGroupBox.Controls.Add(this.BrandLabel);
            this.SystemGroupBox.Controls.Add(this.MemoryLabel);
            this.SystemGroupBox.Controls.Add(this.LCDLabel);
            this.SystemGroupBox.Controls.Add(this.BiglistBox);
            this.SystemGroupBox.Controls.Add(this.ModelTextBox);
            this.SystemGroupBox.Controls.Add(this.PlatformTextBox);
            this.SystemGroupBox.Controls.Add(this.ModelLabel);
            this.SystemGroupBox.Controls.Add(this.ManuTextBox);
            this.SystemGroupBox.Controls.Add(this.PlatformLabel);
            this.SystemGroupBox.Controls.Add(this.ManuLabel);
            this.SystemGroupBox.Controls.Add(this.ConditionTextBox);
            this.SystemGroupBox.Controls.Add(this.CondionLabel);
            this.SystemGroupBox.Location = new System.Drawing.Point(12, 40);
            this.SystemGroupBox.Name = "SystemGroupBox";
            this.SystemGroupBox.Size = new System.Drawing.Size(353, 398);
            this.SystemGroupBox.TabIndex = 1;
            this.SystemGroupBox.TabStop = false;
            this.SystemGroupBox.Text = "System Components";
            // 
            // OS_Label
            // 
            this.OS_Label.AutoSize = true;
            this.OS_Label.Location = new System.Drawing.Point(39, 322);
            this.OS_Label.Name = "OS_Label";
            this.OS_Label.Size = new System.Drawing.Size(22, 13);
            this.OS_Label.TabIndex = 3;
            this.OS_Label.Text = "OS";
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(16, 296);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(51, 13);
            this.WebCamLabel.TabIndex = 3;
            this.WebCamLabel.Text = "WebCam";
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(13, 270);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(57, 13);
            this.GPUTypeLabel.TabIndex = 3;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // HDD_Label
            // 
            this.HDD_Label.AutoSize = true;
            this.HDD_Label.Location = new System.Drawing.Point(36, 246);
            this.HDD_Label.Name = "HDD_Label";
            this.HDD_Label.Size = new System.Drawing.Size(31, 13);
            this.HDD_Label.TabIndex = 3;
            this.HDD_Label.Text = "HDD";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(8, 219);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(63, 13);
            this.SpeedLabel.TabIndex = 3;
            this.SpeedLabel.Text = "CPU Speed";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(6, 192);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(69, 13);
            this.NumberLabel.TabIndex = 3;
            this.NumberLabel.Text = "CPU Number";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(17, 165);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(56, 13);
            this.TypeLabel.TabIndex = 3;
            this.TypeLabel.Text = "CPU Type";
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Location = new System.Drawing.Point(14, 138);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(60, 13);
            this.BrandLabel.TabIndex = 3;
            this.BrandLabel.Text = "CPU Brand";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(29, 110);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(44, 13);
            this.MemoryLabel.TabIndex = 3;
            this.MemoryLabel.Text = "Memory";
            // 
            // LCDLabel
            // 
            this.LCDLabel.AutoSize = true;
            this.LCDLabel.Location = new System.Drawing.Point(25, 86);
            this.LCDLabel.Name = "LCDLabel";
            this.LCDLabel.Size = new System.Drawing.Size(51, 13);
            this.LCDLabel.TabIndex = 3;
            this.LCDLabel.Text = "LCD Size";
            // 
            // BiglistBox
            // 
            this.BiglistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiglistBox.FormattingEnabled = true;
            this.BiglistBox.Location = new System.Drawing.Point(78, 86);
            this.BiglistBox.Name = "BiglistBox";
            this.BiglistBox.Size = new System.Drawing.Size(258, 264);
            this.BiglistBox.TabIndex = 2;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(242, 46);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(94, 20);
            this.ModelTextBox.TabIndex = 1;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Location = new System.Drawing.Point(242, 21);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.Size = new System.Drawing.Size(94, 20);
            this.PlatformTextBox.TabIndex = 1;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(193, 52);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(36, 13);
            this.ModelLabel.TabIndex = 0;
            this.ModelLabel.Text = "Model";
            // 
            // ManuTextBox
            // 
            this.ManuTextBox.Location = new System.Drawing.Point(78, 46);
            this.ManuTextBox.Name = "ManuTextBox";
            this.ManuTextBox.Size = new System.Drawing.Size(94, 20);
            this.ManuTextBox.TabIndex = 1;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(193, 26);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(45, 13);
            this.PlatformLabel.TabIndex = 0;
            this.PlatformLabel.Text = "Platform";
            // 
            // ManuLabel
            // 
            this.ManuLabel.AutoSize = true;
            this.ManuLabel.Location = new System.Drawing.Point(3, 50);
            this.ManuLabel.Name = "ManuLabel";
            this.ManuLabel.Size = new System.Drawing.Size(70, 13);
            this.ManuLabel.TabIndex = 0;
            this.ManuLabel.Text = "Manufacturer";
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Location = new System.Drawing.Point(78, 20);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(94, 20);
            this.ConditionTextBox.TabIndex = 1;
            // 
            // CondionLabel
            // 
            this.CondionLabel.AutoSize = true;
            this.CondionLabel.Location = new System.Drawing.Point(22, 24);
            this.CondionLabel.Name = "CondionLabel";
            this.CondionLabel.Size = new System.Drawing.Size(51, 13);
            this.CondionLabel.TabIndex = 0;
            this.CondionLabel.Text = "Condition";
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.Controls.Add(this.TotalTexBox);
            this.PriceGroupBox.Controls.Add(this.TaxTextBox);
            this.PriceGroupBox.Controls.Add(this.PriceTextBox);
            this.PriceGroupBox.Controls.Add(this.TotalLabel);
            this.PriceGroupBox.Controls.Add(this.TaxLabel);
            this.PriceGroupBox.Controls.Add(this.PriceLabel);
            this.PriceGroupBox.Location = new System.Drawing.Point(388, 205);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Size = new System.Drawing.Size(388, 185);
            this.PriceGroupBox.TabIndex = 2;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Your Price";
            // 
            // TotalTexBox
            // 
            this.TotalTexBox.Location = new System.Drawing.Point(258, 132);
            this.TotalTexBox.Name = "TotalTexBox";
            this.TotalTexBox.Size = new System.Drawing.Size(94, 20);
            this.TotalTexBox.TabIndex = 2;
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.Location = new System.Drawing.Point(258, 78);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.Size = new System.Drawing.Size(94, 20);
            this.TaxTextBox.TabIndex = 2;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(258, 42);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(94, 20);
            this.PriceTextBox.TabIndex = 2;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(30, 131);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(43, 19);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "Total";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLabel.Location = new System.Drawing.Point(30, 81);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(111, 19);
            this.TaxLabel.TabIndex = 0;
            this.TaxLabel.Text = "Sales Tax (13%)";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(30, 43);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(43, 19);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(455, 406);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(547, 406);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(638, 406);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 3;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PriceGroupBox);
            this.Controls.Add(this.SystemGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.Deactivate += new System.EventHandler(this.OrderForm_Deactivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SystemGroupBox.ResumeLayout(false);
            this.SystemGroupBox.PerformLayout();
            this.PriceGroupBox.ResumeLayout(false);
            this.PriceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox SystemGroupBox;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox ManuTextBox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ManuLabel;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.Label CondionLabel;
        private System.Windows.Forms.ListBox BiglistBox;
        private System.Windows.Forms.Label LCDLabel;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDD_Label;
        private System.Windows.Forms.Label OS_Label;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private System.Windows.Forms.TextBox TotalTexBox;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button FinishButton;
    }
}