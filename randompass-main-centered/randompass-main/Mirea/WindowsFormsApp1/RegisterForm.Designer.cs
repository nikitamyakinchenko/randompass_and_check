namespace WindowsFormsApp1
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Joinlabel = new System.Windows.Forms.Label();
            this.checkPasswordLabel = new System.Windows.Forms.Label();
            this.confirmpass = new System.Windows.Forms.TextBox();
            this.repeatpass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckPass = new System.Windows.Forms.CheckBox();
            this.user = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.checkPasswordLabel);
            this.panel1.Controls.Add(this.Joinlabel);
            this.panel1.Controls.Add(this.confirmpass);
            this.panel1.Controls.Add(this.repeatpass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CheckPass);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.loginbutton);
            this.panel1.Controls.Add(this.LoginBox);
            this.panel1.Controls.Add(this.passbox);
            this.panel1.Location = new System.Drawing.Point(193, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 402);
            this.panel1.TabIndex = 8;
            // 
            // Joinlabel
            // 
            this.Joinlabel.AutoSize = true;
            this.Joinlabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Joinlabel.ForeColor = System.Drawing.Color.White;
            this.Joinlabel.Location = new System.Drawing.Point(144, 345);
            this.Joinlabel.Name = "Joinlabel";
            this.Joinlabel.Size = new System.Drawing.Size(91, 14);
            this.Joinlabel.TabIndex = 9;
            this.Joinlabel.Text = "Войти в аккаунт";
            this.Joinlabel.Click += new System.EventHandler(this.Joinlabel_Click);
            //
            // checkPasswordLabel
            //
            this.checkPasswordLabel.AutoSize = true;
            this.checkPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.checkPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkPasswordLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.checkPasswordLabel.Location = new System.Drawing.Point(142, 365);
            this.checkPasswordLabel.Name = "checkPasswordLabel";
            this.checkPasswordLabel.Size = new System.Drawing.Size(94, 14);
            this.checkPasswordLabel.TabIndex = 10;
            this.checkPasswordLabel.Text = "Проверка пароля";
            this.checkPasswordLabel.Click += new System.EventHandler(this.CheckPasswordLabel_Click);
            // 
            // confirmpass
            // 
            this.confirmpass.Location = new System.Drawing.Point(59, 214);
            this.confirmpass.Name = "confirmpass";
            this.confirmpass.Size = new System.Drawing.Size(268, 20);
            this.confirmpass.TabIndex = 8;
            this.confirmpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // repeatpass
            // 
            this.repeatpass.AutoSize = true;
            this.repeatpass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatpass.ForeColor = System.Drawing.Color.White;
            this.repeatpass.Location = new System.Drawing.Point(55, 192);
            this.repeatpass.Name = "repeatpass";
            this.repeatpass.Size = new System.Drawing.Size(178, 19);
            this.repeatpass.TabIndex = 7;
            this.repeatpass.Text = "Подтвердите пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль";
            // 
            // CheckPass
            // 
            this.CheckPass.AutoSize = true;
            this.CheckPass.BackColor = System.Drawing.Color.Transparent;
            this.CheckPass.ForeColor = System.Drawing.Color.White;
            this.CheckPass.Location = new System.Drawing.Point(213, 249);
            this.CheckPass.Name = "CheckPass";
            this.CheckPass.Size = new System.Drawing.Size(114, 17);
            this.CheckPass.TabIndex = 6;
            this.CheckPass.Text = "Показать пароль";
            this.CheckPass.UseVisualStyleBackColor = false;
            this.CheckPass.CheckedChanged += new System.EventHandler(this.CheckPass_CheckedChanged);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(55, 88);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(158, 19);
            this.user.TabIndex = 1;
            this.user.Text = "Имя пользователя";
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginbutton.Location = new System.Drawing.Point(122, 287);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(138, 50);
            this.loginbutton.TabIndex = 5;
            this.loginbutton.Text = "Войти";
            this.loginbutton.UseVisualStyleBackColor = false;
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(59, 110);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(268, 20);
            this.LoginBox.TabIndex = 2;
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(59, 160);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(268, 20);
            this.passbox.TabIndex = 4;
            this.passbox.TextChanged += new System.EventHandler(this.passbox_TextChanged);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.Transparent;
            this.exit.Location = new System.Drawing.Point(770, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 19);
            this.exit.TabIndex = 9;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label repeatpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckPass;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.TextBox confirmpass;
        private System.Windows.Forms.Label Joinlabel;
        private System.Windows.Forms.Label checkPasswordLabel;
        private System.Windows.Forms.Label exit;
    }
}