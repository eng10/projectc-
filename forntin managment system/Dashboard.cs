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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton19_Click(object sender, EventArgs e)
        {
            customer1.BringToFront();
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton16_Click(object sender, EventArgs e)
        {
            employee1.BringToFront();
        }

        private void gunaButton18_Click(object sender, EventArgs e)
        {
            goods1.BringToFront();
        }

        private void gunaButton15_Click(object sender, EventArgs e)
        {
            order1.BringToFront();
        }

        private void gunaButton14_Click(object sender, EventArgs e)
        {
            payment1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void payment1_Load(object sender, EventArgs e)
        {

        }
    }
}
