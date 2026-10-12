namespace WindowsFormsApp1
{
    partial class CheckPasswordForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label exitLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckPasswordForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.promptLabel);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.showPasswordCheckBox);
            this.panel1.Controls.Add(this.checkButton);
            this.panel1.Controls.Add(this.resultLabel);
            this.panel1.Controls.Add(this.registerLabel);
            this.panel1.Location = new System.Drawing.Point(210, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 365);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(86, 46);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(218, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Проверка пароля";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.BackColor = System.Drawing.Color.Transparent;
            this.promptLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.promptLabel.ForeColor = System.Drawing.Color.White;
            this.promptLabel.Location = new System.Drawing.Point(62, 123);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(70, 19);
            this.promptLabel.TabIndex = 1;
            this.promptLabel.Text = "Пароль";
            this.promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(64, 150);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(268, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.showPasswordCheckBox.ForeColor = System.Drawing.Color.White;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(218, 127);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(114, 17);
            this.showPasswordCheckBox.TabIndex = 3;
            this.showPasswordCheckBox.Text = "Показать пароль";
            this.showPasswordCheckBox.UseVisualStyleBackColor = false;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkButton.Location = new System.Drawing.Point(129, 224);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(138, 45);
            this.checkButton.TabIndex = 4;
            this.checkButton.Text = "Проверить";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.resultLabel.ForeColor = System.Drawing.Color.White;
            this.resultLabel.Location = new System.Drawing.Point(20, 176);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(357, 18);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Введите пароль для проверки";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.BackColor = System.Drawing.Color.Transparent;
            this.registerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.ForeColor = System.Drawing.Color.White;
            this.registerLabel.Location = new System.Drawing.Point(153, 279);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(92, 14);
            this.registerLabel.TabIndex = 7;
            this.registerLabel.Text = "Создать аккаунт";
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Transparent;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(772, 9);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(20, 19);
            this.exitLabel.TabIndex = 1;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // CheckPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.panel1);
            this.Name = "CheckPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Проверка пароля";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
