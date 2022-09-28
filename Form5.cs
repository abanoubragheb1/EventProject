using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp19
{
    public partial class ViewMember : Form
    {
        //"CONNECTION BETWEEN "con" AND THE MEMBERTB1 DATABASE"
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GymDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sda;
        DataSet ds = new DataSet();
        public ViewMember()
        {
            InitializeComponent();
            //"CALLING MEMBERTB1 DATABASE AND SHOWING IT"
            sda = new SqlDataAdapter("Select * From MemberTb1", con);
            sda.Fill(ds,"MemberTb1");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //"RETURN MAIN FORM"
            MainForm form2 = new MainForm();
            form2.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}