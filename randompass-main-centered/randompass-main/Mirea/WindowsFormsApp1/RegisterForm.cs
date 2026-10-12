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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            passbox.UseSystemPasswordChar = true;
            confirmpass.UseSystemPasswordChar = true;

            // Делаем обе ссылки видимыми и располагаем вторую под первой.
            Joinlabel.ForeColor = Color.White;
            Joinlabel.BackColor = Color.Transparent;
            Joinlabel.Visible = true;

            checkPasswordLabel.Text = "Проверка пароля";
            checkPasswordLabel.AutoSize = true;
            checkPasswordLabel.ForeColor = Color.White;
            checkPasswordLabel.BackColor = Color.Transparent;
            checkPasswordLabel.Cursor = Cursors.Hand;
            checkPasswordLabel.Visible = true;
            checkPasswordLabel.Location = new Point(
                Joinlabel.Left + (Joinlabel.Width - checkPasswordLabel.PreferredWidth) / 2,
                Joinlabel.Bottom + 6
            );
            checkPasswordLabel.Click -= CheckPasswordLabel_Click;
            checkPasswordLabel.Click += CheckPasswordLabel_Click;
            checkPasswordLabel.BringToFront();
        }

        private void CheckPasswordLabel_Click(object sender, EventArgs e)
        {
            using (CheckPasswordForm form = new CheckPasswordForm())
            {
                form.ShowDialog(this);
            }
        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPass.Checked)
            {
                passbox.UseSystemPasswordChar = false;
                confirmpass.UseSystemPasswordChar = false;
            }
            else
            {
                passbox.UseSystemPasswordChar = true;
                confirmpass.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Joinlabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
