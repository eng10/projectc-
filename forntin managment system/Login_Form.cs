using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forntin_managment_system
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "admin" &&  gunaTextBox2.Text == "123" )
            {
                Dashboard aa = new Dashboard();
                aa.Show();

            }
            else
            {
                MessageBox.Show("possword kaagu waa khadanyahay"," fadlan iska sax", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }


    }
}
