using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace forntin_managment_system
{
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=XIKAM;Initial Catalog=cabdi;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        int ID = 0;
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {

            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from customer", con);
            da.Fill(dt);

            Dvg.DataSource = dt;
            con.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (txt_Cus_Id.Text != "" && txt_Cus_name.Text != "" && txt_Cus_Address.Text != "" && txt_Cus_Gander.Text != "" && txt_Cus_phone.Text != "")
            {
                cmd = new SqlCommand("insert into cumtomer values(@id_cus, @cus_name, @cus_phone, @cus_address, @cus_gander)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id_cus", txt_Cus_Id.Text);
                cmd.Parameters.AddWithValue("@cus_name", txt_Cus_name.Text);
                cmd.Parameters.AddWithValue("@cus_phone", txt_Cus_Address.Text);
                cmd.Parameters.AddWithValue("@cus_address", txt_Cus_Gander.Text);
                cmd.Parameters.AddWithValue("@cus_gander", txt_Cus_phone.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Saved Successfully");
                DisplayData();
                ClearData();
            }
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from cumtomer", con);
            da.Fill(dt);
            Dvg.DataSource = dt;
            con.Close();

        }
        private void ClearData()
        {
            


            ID = 0;
        }
    }
}
