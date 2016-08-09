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
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ListForm Window
            //Select the first item in  the list.
            ProvinceListBox.SetSelected(0, true);
        }

        private void ProvinceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //province list boc
            ProvinceTextBox.Text = ProvinceListBox.SelectedItem.ToString();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //Instantiating an object of the next form - in this case the final form
            FinalForm_ finalForm = new FinalForm_();
            //Pass a reference to the current form (this) to the pub propof the next form
            finalForm.listForm = this;
            //pass some data
            finalForm.ProvinceTextBox.Text = this.ProvinceTextBox.Text;
            //show next form
            finalForm.Show();
            //Hide this form.
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
