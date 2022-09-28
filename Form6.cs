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
    public partial class AddCustomer : Form
    {
        //"Class to calculate the Cost"
        public class Customercost
        {
            public int result;
            public Customercost()
            {
                result = 0;
            }
            public Customercost(int r)
            {
                result = r;
            }
            public int Price(int prot, int crea, int glu, int mul)
            {
                result = (prot * 200) + (crea * 300) + (glu * 432) + (mul * 353);
                return result;
            }
        }
        public AddCustomer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Payment.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void button1_Click(object sender, EventArgs e)
        {
            //"RETURN TO MAIN FORM"
            MainForm log = new MainForm();
            log.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //"MAKE TEXT BOXES EMPTY"
            protein.Text = "";
            creatine.Text ="";
            name1.Text = "";
            multivitamin.Text = "";
            glutamine.Text = "";
            Cost.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //"SHOWING TOTAL COST IN TEXTBOX"
            try
            {
                Customercost c = new Customercost();
                int prot,res,crea,glu,mul;
                prot =  Convert.ToInt32(protein.Text);
                crea= Convert.ToInt32(creatine.Text);  
                glu= Convert.ToInt32(glutamine.Text);
                mul= Convert.ToInt32(multivitamin.Text);
                res = c.Price(prot, crea, glu, mul);
                Cost.Text=res.ToString();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //"ADD CUSTOMER TO PAYMENT DATABASE"
            if (protein.Text == "" || creatine.Text == ""|| name1.Text == "" || multivitamin.Text == "" || glutamine.Text == "" || Cost.Text =="")
            { MessageBox.Show("Missing information"); }
            else
            {
                try
                {
                    con.Open();
                    String query = "INSERT INTO Payment (PName,PProtein,PCreatine,PGlutamine,PMultivitamin,PCost)VALUES('" + name1.Text + "','" + protein.Text + "','" + creatine.Text + "','" + glutamine.Text + "','" + multivitamin.Text + "','" + Cost.Text + "')";
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

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
