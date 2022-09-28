namespace WinFormsApp19
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // RESET "MAKE THE TEXT BOXES EMPTY"
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void log_Click(object sender, EventArgs e)
        {
            // LOG IN "IF THE INFORMATION IS CORRECT YOU CAN LOG IN"

            if (textBox1.Text == "" || textBox2.Text == "") 
            {
                MessageBox.Show("Missing Information");
            }
            else if (textBox1.Text == "a" && textBox2.Text == "a")
            {
                MainForm form = new MainForm();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong ID or Password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // EXIT "CLOSE PROGRAM"
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}