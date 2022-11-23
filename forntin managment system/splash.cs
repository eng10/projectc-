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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void gunaProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            gunaProgressBar1.Increment(3);
            if (gunaProgressBar1.Value ==100)
            {
                timer1.Enabled = false;
                Login_Form dd = new Login_Form();
                dd.Show();
            }
        }
    }
}
