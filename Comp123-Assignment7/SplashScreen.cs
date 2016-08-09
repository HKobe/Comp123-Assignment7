using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp123_Assignment7
{
    public partial class SplashScreen : Form
    {
        public int TimeLeft { get; set; }

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreenMovieLabel_Click(object sender, EventArgs e)
        {

        }
        public int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter += 100;
            if (counter == 1000)
            {
                ListForm LF = new ListForm();
                LF.Show();
                this.Hide();
                timer1.Enabled = false;

                if (TimeLeft > 0)
                {
                    TimeLeft = TimeLeft - 1;

                }
                else
                {
                    
                    timer1.Stop();
                    new ListForm().Show();
                    this.Hide();
                }

            }
            
        }

        private void SplashScreenProgressBar(object sender, EventArgs e)
        {
            ListForm LF = new ListForm();
            LF.Show();
        }

          private void SplashScreen_Load(object sender, EventArgs e)
          {
              TimeLeft = 10;
              timer1.Start();

          }
        
    }
    }

