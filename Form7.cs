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
    public partial class ViewCustomers : Form
    {
        public ViewCustomers()
        {
            InitializeComponent();
            //"CALLING PAYMENT DATABASE AND SHOWING IT"
            sda = new SqlDataAdapter("Select * From Payment", con);
            sda.Fill(ds, "Payment");
            dataGridView1.DataSource = ds.Tables[0];
        }
        //"CONNECTION BETWEEN "con" AND THE PAYMENT DATABASE"
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Payment.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sda;
        DataSet ds = new DataSet();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //"RETURN TO MAIN FORM"
            MainForm form2 = new MainForm();
            form2.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
