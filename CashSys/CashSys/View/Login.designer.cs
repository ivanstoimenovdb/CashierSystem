namespace CashierSystem
{
    partial class LoginForm
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
            this.LoginGroupBox = new System.Windows.Forms.TabControl();
            this.LoginSystem = new System.Windows.Forms.TabPage();
            this.LoginConteiner = new System.Windows.Forms.GroupBox();
            this.SubmitButtonLog = new System.Windows.Forms.Button();
            this.PasswordCashierLogField = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameCashierLogField = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.RegSystem = new System.Windows.Forms.TabPage();
            this.RegistrationGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearButtonReg = new System.Windows.Forms.Button();
            this.ConfirmButtonReg = new System.Windows.Forms.Button();
            this.ConfirmPassCashierRegFiedl = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabelReg = new System.Windows.Forms.Label();
            this.PasswordCashierRegField = new System.Windows.Forms.TextBox();
            this.PasswordLabelReg = new System.Windows.Forms.Label();
            this.UserNameCashierRegField = new System.Windows.Forms.TextBox();
            this.UserNameLabelReg = new System.Windows.Forms.Label();
            this.LnameCashierRegField = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.NameCashierRegField = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LoginGroupBox.SuspendLayout();
            this.LoginSystem.SuspendLayout();
            this.LoginConteiner.SuspendLayout();
            this.RegSystem.SuspendLayout();
            this.RegistrationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Controls.Add(this.LoginSystem);
            this.LoginGroupBox.Controls.Add(this.RegSystem);
            this.LoginGroupBox.Location = new System.Drawing.Point(12, 4);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.SelectedIndex = 0;
            this.LoginGroupBox.Size = new System.Drawing.Size(405, 279);
            this.LoginGroupBox.TabIndex = 0;
            this.LoginGroupBox.SelectedIndexChanged += new System.EventHandler(this.Login_SelectedIndexChanged);
            // 
            // LoginSystem
            // 
            this.LoginSystem.Controls.Add(this.LoginConteiner);
            this.LoginSystem.Location = new System.Drawing.Point(4, 22);
            this.LoginSystem.Name = "LoginSystem";
            this.LoginSystem.Padding = new System.Windows.Forms.Padding(3);
            this.LoginSystem.Size = new System.Drawing.Size(397, 253);
            this.LoginSystem.TabIndex = 0;
            this.LoginSystem.Text = "Вход";
            this.LoginSystem.UseVisualStyleBackColor = true;
            // 
            // LoginConteiner
            // 
            this.LoginConteiner.Controls.Add(this.SubmitButtonLog);
            this.LoginConteiner.Controls.Add(this.PasswordCashierLogField);
            this.LoginConteiner.Controls.Add(this.PasswordLabel);
            this.LoginConteiner.Controls.Add(this.UserNameCashierLogField);
            this.LoginConteiner.Controls.Add(this.UserNameLabel);
            this.LoginConteiner.Location = new System.Drawing.Point(6, 6);
            this.LoginConteiner.Name = "LoginConteiner";
            this.LoginConteiner.Size = new System.Drawing.Size(382, 241);
            this.LoginConteiner.TabIndex = 0;
            this.LoginConteiner.TabStop = false;
            this.LoginConteiner.Text = "Вписване";
            this.LoginConteiner.Enter += new System.EventHandler(this.LoginConteiner_Enter);
            // 
            // SubmitButtonLog
            // 
            this.SubmitButtonLog.Location = new System.Drawing.Point(139, 148);
            this.SubmitButtonLog.Name = "SubmitButtonLog";
            this.SubmitButtonLog.Size = new System.Drawing.Size(94, 23);
            this.SubmitButtonLog.TabIndex = 5;
            this.SubmitButtonLog.Text = "Вход";
            this.SubmitButtonLog.UseVisualStyleBackColor = true;
            this.SubmitButtonLog.Click += new System.EventHandler(this.SubmitButtonLog_Click);
            // 
            // PasswordCashierLogField
            // 
            this.PasswordCashierLogField.Location = new System.Drawing.Point(90, 110);
            this.PasswordCashierLogField.Name = "PasswordCashierLogField";
            this.PasswordCashierLogField.Size = new System.Drawing.Size(195, 20);
            this.PasswordCashierLogField.TabIndex = 4;
            this.PasswordCashierLogField.TextChanged += new System.EventHandler(this.PasswordCashierLogField_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(159, 94);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(51, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Парола :";
            this.PasswordLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // UserNameCashierLogField
            // 
            this.UserNameCashierLogField.Location = new System.Drawing.Point(90, 66);
            this.UserNameCashierLogField.Name = "UserNameCashierLogField";
            this.UserNameCashierLogField.Size = new System.Drawing.Size(195, 20);
            this.UserNameCashierLogField.TabIndex = 2;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(128, 50);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(111, 13);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "Потребителско име:";
            this.UserNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegSystem
            // 
            this.RegSystem.Controls.Add(this.RegistrationGroupBox);
            this.RegSystem.Location = new System.Drawing.Point(4, 22);
            this.RegSystem.Name = "RegSystem";
            this.RegSystem.Padding = new System.Windows.Forms.Padding(3);
            this.RegSystem.Size = new System.Drawing.Size(397, 253);
            this.RegSystem.TabIndex = 1;
            this.RegSystem.Text = "Регистриране";
            this.RegSystem.UseVisualStyleBackColor = true;
            // 
            // RegistrationGroupBox
            // 
            this.RegistrationGroupBox.Controls.Add(this.ClearButtonReg);
            this.RegistrationGroupBox.Controls.Add(this.ConfirmButtonReg);
            this.RegistrationGroupBox.Controls.Add(this.ConfirmPassCashierRegFiedl);
            this.RegistrationGroupBox.Controls.Add(this.ConfirmPasswordLabelReg);
            this.RegistrationGroupBox.Controls.Add(this.PasswordCashierRegField);
            this.RegistrationGroupBox.Controls.Add(this.PasswordLabelReg);
            this.RegistrationGroupBox.Controls.Add(this.UserNameCashierRegField);
            this.RegistrationGroupBox.Controls.Add(this.UserNameLabelReg);
            this.RegistrationGroupBox.Controls.Add(this.LnameCashierRegField);
            this.RegistrationGroupBox.Controls.Add(this.LastNameLabel);
            this.RegistrationGroupBox.Controls.Add(this.NameCashierRegField);
            this.RegistrationGroupBox.Controls.Add(this.FirstNameLabel);
            this.RegistrationGroupBox.Location = new System.Drawing.Point(6, 6);
            this.RegistrationGroupBox.Name = "RegistrationGroupBox";
            this.RegistrationGroupBox.Size = new System.Drawing.Size(385, 241);
            this.RegistrationGroupBox.TabIndex = 0;
            this.RegistrationGroupBox.TabStop = false;
            this.RegistrationGroupBox.Text = "Регистрация";
            this.RegistrationGroupBox.Enter += new System.EventHandler(this.RegistrationGroupBox_Enter);
            // 
            // ClearButtonReg
            // 
            this.ClearButtonReg.Location = new System.Drawing.Point(244, 187);
            this.ClearButtonReg.Name = "ClearButtonReg";
            this.ClearButtonReg.Size = new System.Drawing.Size(75, 23);
            this.ClearButtonReg.TabIndex = 11;
            this.ClearButtonReg.Text = "Изчисти";
            this.ClearButtonReg.UseVisualStyleBackColor = true;
            this.ClearButtonReg.Click += new System.EventHandler(this.ClearButtonReg_Click);
            // 
            // ConfirmButtonReg
            // 
            this.ConfirmButtonReg.Location = new System.Drawing.Point(90, 187);
            this.ConfirmButtonReg.Name = "ConfirmButtonReg";
            this.ConfirmButtonReg.Size = new System.Drawing.Size(87, 23);
            this.ConfirmButtonReg.TabIndex = 10;
            this.ConfirmButtonReg.Text = "Регистрирай";
            this.ConfirmButtonReg.UseVisualStyleBackColor = true;
            this.ConfirmButtonReg.Click += new System.EventHandler(this.ConfirmButtonReg_Click);
            // 
            // ConfirmPassCashierRegFiedl
            // 
            this.ConfirmPassCashierRegFiedl.Location = new System.Drawing.Point(117, 144);
            this.ConfirmPassCashierRegFiedl.Name = "ConfirmPassCashierRegFiedl";
            this.ConfirmPassCashierRegFiedl.Size = new System.Drawing.Size(240, 20);
            this.ConfirmPassCashierRegFiedl.TabIndex = 9;
            // 
            // ConfirmPasswordLabelReg
            // 
            this.ConfirmPasswordLabelReg.AutoSize = true;
            this.ConfirmPasswordLabelReg.Location = new System.Drawing.Point(33, 147);
            this.ConfirmPasswordLabelReg.Name = "ConfirmPasswordLabelReg";
            this.ConfirmPasswordLabelReg.Size = new System.Drawing.Size(74, 13);
            this.ConfirmPasswordLabelReg.TabIndex = 8;
            this.ConfirmPasswordLabelReg.Text = "Потв парола:";
            this.ConfirmPasswordLabelReg.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // PasswordCashierRegField
            // 
            this.PasswordCashierRegField.Location = new System.Drawing.Point(117, 117);
            this.PasswordCashierRegField.Name = "PasswordCashierRegField";
            this.PasswordCashierRegField.Size = new System.Drawing.Size(240, 20);
            this.PasswordCashierRegField.TabIndex = 7;
            // 
            // PasswordLabelReg
            // 
            this.PasswordLabelReg.AutoSize = true;
            this.PasswordLabelReg.Location = new System.Drawing.Point(47, 120);
            this.PasswordLabelReg.Name = "PasswordLabelReg";
            this.PasswordLabelReg.Size = new System.Drawing.Size(48, 13);
            this.PasswordLabelReg.TabIndex = 6;
            this.PasswordLabelReg.Text = "Парола:";
            // 
            // UserNameCashierRegField
            // 
            this.UserNameCashierRegField.Location = new System.Drawing.Point(117, 90);
            this.UserNameCashierRegField.Name = "UserNameCashierRegField";
            this.UserNameCashierRegField.Size = new System.Drawing.Size(240, 20);
            this.UserNameCashierRegField.TabIndex = 5;
            // 
            // UserNameLabelReg
            // 
            this.UserNameLabelReg.AutoSize = true;
            this.UserNameLabelReg.Location = new System.Drawing.Point(0, 93);
            this.UserNameLabelReg.Name = "UserNameLabelReg";
            this.UserNameLabelReg.Size = new System.Drawing.Size(111, 13);
            this.UserNameLabelReg.TabIndex = 4;
            this.UserNameLabelReg.Text = "Потребителско име:";
            // 
            // LnameCashierRegField
            // 
            this.LnameCashierRegField.Location = new System.Drawing.Point(117, 64);
            this.LnameCashierRegField.Name = "LnameCashierRegField";
            this.LnameCashierRegField.Size = new System.Drawing.Size(240, 20);
            this.LnameCashierRegField.TabIndex = 3;
            this.LnameCashierRegField.TextChanged += new System.EventHandler(this.LnameCashierRegField_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(48, 67);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Фамилия:";
            // 
            // NameCashierRegField
            // 
            this.NameCashierRegField.Location = new System.Drawing.Point(117, 37);
            this.NameCashierRegField.Name = "NameCashierRegField";
            this.NameCashierRegField.Size = new System.Drawing.Size(240, 20);
            this.NameCashierRegField.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(63, 40);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(32, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "Име:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 295);
            this.Controls.Add(this.LoginGroupBox);
            this.Name = "LoginForm";
            this.Text = "Вписване";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginSystem.ResumeLayout(false);
            this.LoginConteiner.ResumeLayout(false);
            this.LoginConteiner.PerformLayout();
            this.RegSystem.ResumeLayout(false);
            this.RegistrationGroupBox.ResumeLayout(false);
            this.RegistrationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LoginGroupBox;
        private System.Windows.Forms.TabPage LoginSystem;
        private System.Windows.Forms.TabPage RegSystem;
        private System.Windows.Forms.GroupBox LoginConteiner;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserNameCashierLogField;
        private System.Windows.Forms.Button SubmitButtonLog;
        private System.Windows.Forms.TextBox PasswordCashierLogField;
        private System.Windows.Forms.GroupBox RegistrationGroupBox;
        private System.Windows.Forms.Label ConfirmPasswordLabelReg;
        private System.Windows.Forms.TextBox PasswordCashierRegField;
        private System.Windows.Forms.Label PasswordLabelReg;
        private System.Windows.Forms.TextBox UserNameCashierRegField;
        private System.Windows.Forms.Label UserNameLabelReg;
        private System.Windows.Forms.TextBox LnameCashierRegField;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox NameCashierRegField;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button ClearButtonReg;
        private System.Windows.Forms.Button ConfirmButtonReg;
        private System.Windows.Forms.TextBox ConfirmPassCashierRegFiedl;
    }
}

