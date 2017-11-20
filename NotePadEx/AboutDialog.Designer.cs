namespace NotePadEx
{
    partial class AboutDialog
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
            this.Company = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Edition = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Company
            // 
            this.Company.AutoSize = true;
            this.Company.Location = new System.Drawing.Point(18, 33);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(27, 13);
            this.Company.TabIndex = 0;
            this.Company.Text = "MFT";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Levenim MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Title.Location = new System.Drawing.Point(4, 46);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(299, 65);
            this.Title.TabIndex = 0;
            this.Title.Text = "NotePad Ex";
            // 
            // Edition
            // 
            this.Edition.AutoSize = true;
            this.Edition.Location = new System.Drawing.Point(222, 111);
            this.Edition.Name = "Edition";
            this.Edition.Size = new System.Drawing.Size(80, 13);
            this.Edition.TabIndex = 0;
            this.Edition.Text = "Stanard Edition";
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Location = new System.Drawing.Point(12, 178);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(138, 13);
            this.Copyright.TabIndex = 0;
            this.Copyright.Text = "copyright© MFT 2011, Inc.";
            // 
            // Exit
            // 
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Location = new System.Drawing.Point(225, 168);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "&Close";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // AboutDialog
            // 
            this.AcceptButton = this.Exit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(314, 208);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.Edition);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Company);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Company;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Edition;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Button Exit;
    }
}