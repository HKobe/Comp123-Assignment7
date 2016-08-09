namespace Comp123_Assignment7
{
    partial class SplashScreen
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
            this.SplashScreenPorgressBar = new System.Windows.Forms.ProgressBar();
            this.SplashScreenMovieLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SplashScreenPorgressBar
            // 
            this.SplashScreenPorgressBar.Location = new System.Drawing.Point(36, 325);
            this.SplashScreenPorgressBar.Maximum = 1000;
            this.SplashScreenPorgressBar.Name = "SplashScreenPorgressBar";
            this.SplashScreenPorgressBar.Size = new System.Drawing.Size(360, 53);
            this.SplashScreenPorgressBar.TabIndex = 0;
            this.SplashScreenPorgressBar.Click += new System.EventHandler(this.SplashScreenProgressBar);
            // 
            // SplashScreenMovieLabel
            // 
            this.SplashScreenMovieLabel.AutoSize = true;
            this.SplashScreenMovieLabel.BackColor = System.Drawing.Color.Transparent;
            this.SplashScreenMovieLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashScreenMovieLabel.Location = new System.Drawing.Point(42, 95);
            this.SplashScreenMovieLabel.Name = "SplashScreenMovieLabel";
            this.SplashScreenMovieLabel.Size = new System.Drawing.Size(344, 40);
            this.SplashScreenMovieLabel.TabIndex = 1;
            this.SplashScreenMovieLabel.Text = "Movie Bonanzaaaaaa!";
            this.SplashScreenMovieLabel.Click += new System.EventHandler(this.SplashScreenMovieLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Comp123_Assignment7.Properties.Resources.locker_bg;
            this.ClientSize = new System.Drawing.Size(426, 470);
            this.Controls.Add(this.SplashScreenMovieLabel);
            this.Controls.Add(this.SplashScreenPorgressBar);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar SplashScreenPorgressBar;
        private System.Windows.Forms.Label SplashScreenMovieLabel;
        private System.Windows.Forms.Timer timer1;
    }
}