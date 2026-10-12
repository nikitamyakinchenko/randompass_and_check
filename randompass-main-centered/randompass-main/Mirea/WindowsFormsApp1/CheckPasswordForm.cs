
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CheckPasswordForm : Form
    {
        private Label detailsLabel;

        public CheckPasswordForm()
        {
            InitializeComponent();

            passwordTextBox.UseSystemPasswordChar = true;

            // Создаём поле с рекомендациями.
            detailsLabel = new Label();
            detailsLabel.Name = "detailsLabel";
            detailsLabel.AutoSize = false;
            detailsLabel.Size = new Size(357, 50);
            detailsLabel.Location = new Point(20, 278);
            detailsLabel.ForeColor = Color.White;
            detailsLabel.BackColor = Color.Transparent;
            detailsLabel.Font = new Font("Arial", 9F);
            detailsLabel.Text = "Минимальная длина — 8 символов.";
            detailsLabel.TextAlign = ContentAlignment.TopCenter;

            // Добавляем поле внутрь тёмной панели.
            panel1.Controls.Add(detailsLabel);
            detailsLabel.BringToFront();
        }

        private void showPasswordCheckBox_CheckedChanged(
            object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar =
                !showPasswordCheckBox.Checked;
        }

        private void passwordTextBox_TextChanged(
            object sender, EventArgs e)
        {
            resultLabel.Text = passwordTextBox.Text.Length == 0
                ? "Введите пароль для проверки"
                : "Нажмите «Проверить»";

            resultLabel.ForeColor = Color.White;

            detailsLabel.Text =
                "Минимальная длина — 8 символов.";
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;

            if (password.Length == 0)
            {
                resultLabel.Text = "Введите пароль для проверки";
                resultLabel.ForeColor = Color.White;

                detailsLabel.Text =
                    "Введите пароль длиной не менее 8 символов.";
                return;
            }

            int score = 0;
            string details = "";

            bool upper = Regex.IsMatch(password, "[A-ZА-ЯЁ]");
            bool lower = Regex.IsMatch(password, "[a-zа-яё]");
            bool digit = Regex.IsMatch(password, "[0-9]");
            bool special = Regex.IsMatch(
                password, @"[^a-zA-Zа-яА-ЯёЁ0-9\s]");
            bool longPassword = password.Length >= 12;

            if (longPassword)
                score++;
            else
                details += "• Используйте 12 или более символов.\n";

            if (upper)
                score++;
            else
                details += "• Добавьте заглавную букву.\n";

            if (lower)
                score++;
            else
                details += "• Добавьте строчную букву.\n";

            if (digit)
                score++;
            else
                details += "• Добавьте цифру.\n";

            if (special)
                score++;
            else
                details += "• Добавьте специальный символ.\n";

            if (score <= 2)
            {
                resultLabel.Text = "Пароль ненадёжный";
                resultLabel.ForeColor = Color.OrangeRed;
            }
            else if (score <= 4)
            {
                resultLabel.Text = "Пароль недостаточно надёжный";
                resultLabel.ForeColor = Color.Gold;
            }
            else
            {
                resultLabel.Text = "Пароль надёжный";
                resultLabel.ForeColor = Color.LightGreen;
            }

            detailsLabel.Text = details.Length == 0
                ? "Все основные требования выполнены."
                : details.TrimEnd('\n');
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            using (RegisterForm form = new RegisterForm())
            {
                form.ShowDialog(this);
            }
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
