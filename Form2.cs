using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp19
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dele_Click(object sender, EventArgs e)
        {
            // "OPEN DELETE MEMBERS FORM"
            DeleteMember form4 = new DeleteMember();
            form4.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            // "OPEN ADD MEMBER FORM"
            AddMember form3 = new AddMember();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // "OPEN VIEW MEMBERS FORM" 
            ViewMember form5 = new ViewMember();
            form5.Show();
            this.Hide();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            // "OPEN ADD CUSTOMER FORM"
            AddCustomer form6 = new AddCustomer();
            form6.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //"RETURN TO LOG IN FORM"
            LogIn form1 = new LogIn();
            form1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //"OPEN VIEW CUSTOMERS FORM"
            ViewCustomers form7 = new ViewCustomers();
            form7.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //"OPEN DELETE CUSTOMERS FORM"
            DeleteCustomers form8 = new DeleteCustomers();
            form8.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
