using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp19
{
    public partial class DeleteCustomers : Form
    {
        //"CONNECTION BETWEEN "con" AND THE PAYMENT DATABASE"
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Payment.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sda;
        DataSet ds = new DataSet();
        public DeleteCustomers()
        {
            InitializeComponent();
            //"CALLING PAYMENT DATABASE AND SHOW IT"
            sda = new SqlDataAdapter("Select * From Payment", con);
            sda.Fill(ds, "Payment");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //"DELETE MEMBER FROM PAYMENT DATABASE"
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Payment.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand com = new SqlCommand("Delete Payment where Id = '" + id + "'", con);
            com.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //"RETURN TO MAIN FORM"
            MainForm form2 = new MainForm();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //"REFRESH THE PAYMENT DATABASE AND SHOW IT"
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Payment.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand com = new SqlCommand("Select * From Payment", con);
            SqlDataAdapter d = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
