namespace WindowsFormsApp1
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Log = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.passbox = new System.Windows.Forms.TextBox();
            this.join = new System.Windows.Forms.Button();
            this.CheckPass = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerlabel = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.BackColor = System.Drawing.Color.Transparent;
            this.Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log.ForeColor = System.Drawing.Color.White;
            this.Log.Location = new System.Drawing.Point(92, 31);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(167, 30);
            this.Log.TabIndex = 0;
            this.Log.Text = "Авторизация";
            this.Log.Click += new System.EventHandler(this.label1_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(32, 88);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(57, 19);
            this.login.TabIndex = 1;
            this.login.Text = "Логин";
            this.login.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(36, 110);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(268, 20);
            this.LoginBox.TabIndex = 2;
            this.LoginBox.TextChanged += new System.EventHandler(this.LoginBox_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(32, 148);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(70, 19);
            this.Password.TabIndex = 3;
            this.Password.Text = "Пароль";
            this.Password.Click += new System.EventHandler(this.label3_Click);
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(36, 170);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(268, 20);
            this.passbox.TabIndex = 4;
            this.passbox.TextChanged += new System.EventHandler(this.passbox_TextChanged);
            // 
            // join
            // 
            this.join.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.join.Location = new System.Drawing.Point(97, 240);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(138, 50);
            this.join.TabIndex = 5;
            this.join.Text = "Войти";
            this.join.UseVisualStyleBackColor = false;
            this.join.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // CheckPass
            // 
            this.CheckPass.AutoSize = true;
            this.CheckPass.BackColor = System.Drawing.Color.Transparent;
            this.CheckPass.ForeColor = System.Drawing.Color.White;
            this.CheckPass.Location = new System.Drawing.Point(190, 196);
            this.CheckPass.Name = "CheckPass";
            this.CheckPass.Size = new System.Drawing.Size(114, 17);
            this.CheckPass.TabIndex = 6;
            this.CheckPass.Text = "Показать пароль";
            this.CheckPass.UseVisualStyleBackColor = false;
            this.CheckPass.CheckedChanged += new System.EventHandler(this.CheckPass_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.registerlabel);
            this.panel1.Controls.Add(this.Log);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.CheckPass);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.join);
            this.panel1.Controls.Add(this.LoginBox);
            this.panel1.Controls.Add(this.passbox);
            this.panel1.Location = new System.Drawing.Point(225, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 345);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // registerlabel
            // 
            this.registerlabel.AutoSize = true;
            this.registerlabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerlabel.ForeColor = System.Drawing.Color.Transparent;
            this.registerlabel.Location = new System.Drawing.Point(119, 293);
            this.registerlabel.Name = "registerlabel";
            this.registerlabel.Size = new System.Drawing.Size(92, 14);
            this.registerlabel.TabIndex = 7;
            this.registerlabel.Text = "Создать аккаунт";
            this.registerlabel.Click += new System.EventHandler(this.registerlabel_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.Transparent;
            this.exit.Location = new System.Drawing.Point(772, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 19);
            this.exit.TabIndex = 10;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Button join;
        private System.Windows.Forms.CheckBox CheckPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label registerlabel;
        private System.Windows.Forms.Label exit;
    }
}

