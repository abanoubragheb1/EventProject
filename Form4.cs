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
    public partial class DeleteMember : Form
    {
        //"CONNECTION BETWEEN "con" AND THE MEMBERTB1 DATABASE"
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GymDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sda;
        DataSet ds = new DataSet();
        public DeleteMember()
        {
            InitializeComponent();
            //"CALLING MEMBERTB1 DATABASE AND SHOW IT"
            sda = new SqlDataAdapter("Select * From MemberTb1", con);
            sda.Fill(ds, "MemberTb1");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //"REFRESH THE MEMBERTB1 DATABASE AND SHOW IT"
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GymDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand com = new SqlCommand("Select * From MemberTb1",con);
            SqlDataAdapter d= new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //"RETURN TO MAIN FORM"
            MainForm form2 = new MainForm();
            form2.Show();
            this.Hide();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //"DELETE MEMBER FROM MEMBERTB1 DATABASE"
            int id = Convert.ToInt32( dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GymDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand com = new SqlCommand("Delete MemberTb1 where Id = '" +id+ "'",con);
            com.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted");
            con.Close();
        }
    }
}
