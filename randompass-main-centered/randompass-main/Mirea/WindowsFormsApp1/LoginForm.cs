using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            passbox.UseSystemPasswordChar = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CheckPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPass.Checked)
            {
                passbox.UseSystemPasswordChar = false;
            }
            else
            {
                passbox.UseSystemPasswordChar= true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {

        }

        private void registerlabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
