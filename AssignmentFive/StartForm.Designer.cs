namespace AssignmentFive
{
    partial class StartForm
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
            this.NewButton = new System.Windows.Forms.Button();
            this.LoadButtom = new System.Windows.Forms.Button();
            this.ExitButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Location = new System.Drawing.Point(34, 145);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(310, 59);
            this.NewButton.TabIndex = 0;
            this.NewButton.Text = "New Order";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // LoadButtom
            // 
            this.LoadButtom.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButtom.Location = new System.Drawing.Point(34, 238);
            this.LoadButtom.Name = "LoadButtom";
            this.LoadButtom.Size = new System.Drawing.Size(310, 59);
            this.LoadButtom.TabIndex = 0;
            this.LoadButtom.Text = "Load a saved Order";
            this.LoadButtom.UseVisualStyleBackColor = true;
            this.LoadButtom.Click += new System.EventHandler(this.LoadButtom_Click);
            // 
            // ExitButtom
            // 
            this.ExitButtom.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButtom.Location = new System.Drawing.Point(34, 333);
            this.ExitButtom.Name = "ExitButtom";
            this.ExitButtom.Size = new System.Drawing.Size(310, 59);
            this.ExitButtom.TabIndex = 1;
            this.ExitButtom.Text = "Exit";
            this.ExitButtom.UseVisualStyleBackColor = true;
            this.ExitButtom.Click += new System.EventHandler(this.ExitButtom_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButtom);
            this.Controls.Add(this.LoadButtom);
            this.Controls.Add(this.NewButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button LoadButtom;
        private System.Windows.Forms.Button ExitButtom;
    }
}

