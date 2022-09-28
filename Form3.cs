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
    public partial class AddMember : Form
    {
        //"Class to calculate the Price"
        public class Memberprice
        {
            public int result;           
            public Memberprice()
            {
                result = 0;
            }
            public Memberprice(int r)
            {
                result = r;
            }
            public int Price(int x)
            {
                result = (x * 400);    
                return result;
            }
        }
        public AddMember()
        {
            InitializeComponent();
        }
        //"CONNECTION BETWEEN "con" AND THE MEMBERTB1 DATABASE""
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GymDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //"ADD MEMBER TO DATABASE"
            if (NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == "" || AgeTb.Text == "")
            { MessageBox.Show("Missing information"); }
            else
            {
                try
                {
                    con.Open();
                    String query = "INSERT INTO MemberTb1 (MName,MPhone,MAge,MAmount,MTiming,MGender)VALUES('"+ NameTb.Text + "','" +PhoneTb.Text + "','" + AgeTb.Text + "','" + AmountTb.Text + "','" + TimingCb.Text + "','" + GenderCb.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Added");
                    
                    con.Close();
                   
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //"MAKE ALL TEXT BOXS EMPTY"
            AmountTb.Text = "";
            AgeTb.Text = "";
            NameTb.Text = "";
            PhoneTb.Text = "";
            GenderCb.Text = "";
            TimingCb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //"RETURN TO MAIN FORM"
            MainForm log = new MainForm();
            log.Show();
            this.Hide();
        }

        private void AmountTb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //"SHOWING TOAL PRICE IN A TEXT BOX"
            Memberprice x = new Memberprice();
            int mon, res;
            mon = Convert.ToInt32(Nmonthes.Text);
            res = x.Price(mon);
            AmountTb.Text = res.ToString();
        }
    }
}
