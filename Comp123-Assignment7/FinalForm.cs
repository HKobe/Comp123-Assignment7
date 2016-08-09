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
    public partial class FinalForm_ : Form
    {
        public ListForm listForm { get; set; }
        public FinalForm_()
        {
            InitializeComponent();
        }

        private void FinalForm__Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.listForm.Show();
            this.Close();
        }

        private void exitCTRLXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            //SHOW dIALOG
            aboutBox.ShowDialog();
        }
    }
}
