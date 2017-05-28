using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Login : Form
    {
        private UserService _userService;
        public Login(UserService userService)
        {
            InitializeComponent();

            _userService = userService;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("asdasd");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var userExists = _userService.Check(this.username.Text, this.password.Text);
            if (userExists)
            {
                MessageBox.Show("tuyn a");
                Application.Exit();
            } else
            {
                MessageBox.Show("krkin pordzeq");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var signupForm = new Signup(_userService);
            signupForm.Show();
        }

    }
}
