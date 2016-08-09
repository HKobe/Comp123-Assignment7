namespace Comp123_Assignment7
{
    partial class FinalForm_
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
            this.ProvinceTextBox = new System.Windows.Forms.TextBox();
            this.ProvinceLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.FinalFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FinalFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProvinceTextBox
            // 
            this.ProvinceTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProvinceTextBox.Enabled = false;
            this.ProvinceTextBox.Font = new System.Drawing.Font("Lucida Sans", 15F);
            this.ProvinceTextBox.Location = new System.Drawing.Point(12, 86);
            this.ProvinceTextBox.MinimumSize = new System.Drawing.Size(25, 50);
            this.ProvinceTextBox.Name = "ProvinceTextBox";
            this.ProvinceTextBox.ReadOnly = true;
            this.ProvinceTextBox.Size = new System.Drawing.Size(400, 37);
            this.ProvinceTextBox.TabIndex = 6;
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvinceLabel.Location = new System.Drawing.Point(6, 27);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(140, 34);
            this.ProvinceLabel.TabIndex = 5;
            this.ProvinceLabel.Text = "Province";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(18, 309);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(112, 50);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FinalFormMenuStrip
            // 
            this.FinalFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FinalFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpMenuItem,
            this.FileMenuItem});
            this.FinalFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.FinalFormMenuStrip.Name = "FinalFormMenuStrip";
            this.FinalFormMenuStrip.Size = new System.Drawing.Size(546, 28);
            this.FinalFormMenuStrip.TabIndex = 8;
            this.FinalFormMenuStrip.Text = "menuStrip1";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.ShortcutKeyDisplayString = "CTRL+A";
            this.HelpMenuItem.Size = new System.Drawing.Size(53, 24);
            this.HelpMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.ShortcutKeyDisplayString = "CTRL+B";
            this.AboutMenuItem.Size = new System.Drawing.Size(186, 26);
            this.AboutMenuItem.Text = "About";
            this.AboutMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackMenuItem,
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(44, 24);
            this.FileMenuItem.Text = "File";
            // 
            // BackMenuItem
            // 
            this.BackMenuItem.Name = "BackMenuItem";
            this.BackMenuItem.ShortcutKeyDisplayString = "CTRL+B";
            this.BackMenuItem.Size = new System.Drawing.Size(188, 26);
            this.BackMenuItem.Text = "Back   ";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.ShortcutKeyDisplayString = "CTRL+X";
            this.ExitMenuItem.Size = new System.Drawing.Size(188, 26);
            this.ExitMenuItem.Text = "Exit ";
            this.ExitMenuItem.Click += new System.EventHandler(this.exitCTRLXToolStripMenuItem_Click);
            // 
            // FinalForm_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 371);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ProvinceTextBox);
            this.Controls.Add(this.ProvinceLabel);
            this.Controls.Add(this.FinalFormMenuStrip);
            this.MainMenuStrip = this.FinalFormMenuStrip;
            this.Name = "FinalForm_";
            this.ShowIcon = false;
            this.Text = "FinalForm_";
            this.Load += new System.EventHandler(this.FinalForm__Load);
            this.FinalFormMenuStrip.ResumeLayout(false);
            this.FinalFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ProvinceLabel;
        private System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.TextBox ProvinceTextBox;
        private System.Windows.Forms.MenuStrip FinalFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
    }
}