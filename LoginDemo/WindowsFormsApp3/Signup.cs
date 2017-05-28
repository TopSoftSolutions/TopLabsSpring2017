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
    public partial class Signup : Form
    {
        private UserService _userService;
        public Signup(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void RetryPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _userService.Register(this.Name.Text, this.username.Text, this.Password.Text);
            this.Close();
        }
    }
}
