namespace CashierSystem.View
{
    partial class AdministrationPanel
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
            this.AdminTab = new System.Windows.Forms.TabControl();
            this.PaymentsTab = new System.Windows.Forms.TabPage();
            this.PaymentsGroupBox = new System.Windows.Forms.GroupBox();
            this.NameOfObligPaymentsField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IdOfObligationPaymentField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PayAmountPaymentField = new System.Windows.Forms.TextBox();
            this.SumLabel = new System.Windows.Forms.Label();
            this.ClearPaymentsButton = new System.Windows.Forms.Button();
            this.ConfirmPaymentsButton = new System.Windows.Forms.Button();
            this.ClientNumberPaymentsField = new System.Windows.Forms.TextBox();
            this.ClientNumber = new System.Windows.Forms.Label();
            this.SignObligationsTab = new System.Windows.Forms.TabPage();
            this.SignOblGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameOfOblSignOblField = new System.Windows.Forms.TextBox();
            this.ClientNumberSignOblField = new System.Windows.Forms.TextBox();
            this.CategoryOblSignOblField = new System.Windows.Forms.TextBox();
            this.ConfirmSignOblBtn = new System.Windows.Forms.Button();
            this.ClearSignOblBtn = new System.Windows.Forms.Button();
            this.SignUserTab = new System.Windows.Forms.TabPage();
            this.InfoFormTab = new System.Windows.Forms.TabPage();
            this.SignUserGroupBox = new System.Windows.Forms.GroupBox();
            this.SignUserFirstNameLabel = new System.Windows.Forms.Label();
            this.SignUserLastNameLabel = new System.Windows.Forms.Label();
            this.SignUserEgnLabel = new System.Windows.Forms.Label();
            this.SignUserFirstNameField = new System.Windows.Forms.TextBox();
            this.SignUserLastNameField = new System.Windows.Forms.TextBox();
            this.SignUserEgnField = new System.Windows.Forms.TextBox();
            this.SignUserButton = new System.Windows.Forms.Button();
            this.SignUserGeneratedClientNumberLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SignUserClrBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.InfoOblFirstNameLabel = new System.Windows.Forms.Label();
            this.InfoOblLNameLabel = new System.Windows.Forms.Label();
            this.InfoOblClientNLabel = new System.Windows.Forms.Label();
            this.InfoOblEGNLabel = new System.Windows.Forms.Label();
            this.InfoOblFirstNameField = new System.Windows.Forms.TextBox();
            this.InfoOblLastNameField = new System.Windows.Forms.TextBox();
            this.InfoOblEgnField = new System.Windows.Forms.TextBox();
            this.InfoOblCliNumField = new System.Windows.Forms.TextBox();
            this.InfoOblGetInfoBtn = new System.Windows.Forms.Button();
            this.InfoOblClrBtn = new System.Windows.Forms.Button();
            this.InfoOblResultRichBox = new System.Windows.Forms.RichTextBox();
            this.AdminTab.SuspendLayout();
            this.PaymentsTab.SuspendLayout();
            this.PaymentsGroupBox.SuspendLayout();
            this.SignObligationsTab.SuspendLayout();
            this.SignOblGroupBox.SuspendLayout();
            this.SignUserTab.SuspendLayout();
            this.InfoFormTab.SuspendLayout();
            this.SignUserGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminTab
            // 
            this.AdminTab.Controls.Add(this.PaymentsTab);
            this.AdminTab.Controls.Add(this.SignObligationsTab);
            this.AdminTab.Controls.Add(this.SignUserTab);
            this.AdminTab.Controls.Add(this.InfoFormTab);
            this.AdminTab.Location = new System.Drawing.Point(12, 12);
            this.AdminTab.Name = "AdminTab";
            this.AdminTab.SelectedIndex = 0;
            this.AdminTab.Size = new System.Drawing.Size(575, 314);
            this.AdminTab.TabIndex = 0;
            // 
            // PaymentsTab
            // 
            this.PaymentsTab.Controls.Add(this.PaymentsGroupBox);
            this.PaymentsTab.Location = new System.Drawing.Point(4, 22);
            this.PaymentsTab.Name = "PaymentsTab";
            this.PaymentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.PaymentsTab.Size = new System.Drawing.Size(567, 288);
            this.PaymentsTab.TabIndex = 0;
            this.PaymentsTab.Text = "Плащания";
            this.PaymentsTab.UseVisualStyleBackColor = true;
            // 
            // PaymentsGroupBox
            // 
            this.PaymentsGroupBox.Controls.Add(this.NameOfObligPaymentsField);
            this.PaymentsGroupBox.Controls.Add(this.label3);
            this.PaymentsGroupBox.Controls.Add(this.IdOfObligationPaymentField);
            this.PaymentsGroupBox.Controls.Add(this.label2);
            this.PaymentsGroupBox.Controls.Add(this.label5);
            this.PaymentsGroupBox.Controls.Add(this.PayAmountPaymentField);
            this.PaymentsGroupBox.Controls.Add(this.SumLabel);
            this.PaymentsGroupBox.Controls.Add(this.ClearPaymentsButton);
            this.PaymentsGroupBox.Controls.Add(this.ConfirmPaymentsButton);
            this.PaymentsGroupBox.Controls.Add(this.ClientNumberPaymentsField);
            this.PaymentsGroupBox.Controls.Add(this.ClientNumber);
            this.PaymentsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.PaymentsGroupBox.Name = "PaymentsGroupBox";
            this.PaymentsGroupBox.Size = new System.Drawing.Size(555, 276);
            this.PaymentsGroupBox.TabIndex = 0;
            this.PaymentsGroupBox.TabStop = false;
            this.PaymentsGroupBox.Text = "Плащания";
            // 
            // NameOfObligPaymentsField
            // 
            this.NameOfObligPaymentsField.Location = new System.Drawing.Point(175, 131);
            this.NameOfObligPaymentsField.Name = "NameOfObligPaymentsField";
            this.NameOfObligPaymentsField.Size = new System.Drawing.Size(270, 20);
            this.NameOfObligPaymentsField.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Име на задължение:";
            // 
            // IdOfObligationPaymentField
            // 
            this.IdOfObligationPaymentField.Location = new System.Drawing.Point(175, 104);
            this.IdOfObligationPaymentField.Name = "IdOfObligationPaymentField";
            this.IdOfObligationPaymentField.Size = new System.Drawing.Size(270, 20);
            this.IdOfObligationPaymentField.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Номер на задължението*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Полетата със \"*\" са задължителни !!!";
            // 
            // PayAmountPaymentField
            // 
            this.PayAmountPaymentField.Location = new System.Drawing.Point(175, 78);
            this.PayAmountPaymentField.Name = "PayAmountPaymentField";
            this.PayAmountPaymentField.Size = new System.Drawing.Size(270, 20);
            this.PayAmountPaymentField.TabIndex = 10;
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(84, 81);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(85, 13);
            this.SumLabel.TabIndex = 9;
            this.SumLabel.Text = "Платена сума*:";
            this.SumLabel.Click += new System.EventHandler(this.SumLabel_Click);
            // 
            // ClearPaymentsButton
            // 
            this.ClearPaymentsButton.Location = new System.Drawing.Point(370, 168);
            this.ClearPaymentsButton.Name = "ClearPaymentsButton";
            this.ClearPaymentsButton.Size = new System.Drawing.Size(75, 23);
            this.ClearPaymentsButton.TabIndex = 8;
            this.ClearPaymentsButton.Text = "Изчисти";
            this.ClearPaymentsButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmPaymentsButton
            // 
            this.ConfirmPaymentsButton.Location = new System.Drawing.Point(175, 168);
            this.ConfirmPaymentsButton.Name = "ConfirmPaymentsButton";
            this.ConfirmPaymentsButton.Size = new System.Drawing.Size(119, 23);
            this.ConfirmPaymentsButton.TabIndex = 7;
            this.ConfirmPaymentsButton.Text = "Впиши плащане";
            this.ConfirmPaymentsButton.UseVisualStyleBackColor = true;
            // 
            // ClientNumberPaymentsField
            // 
            this.ClientNumberPaymentsField.Location = new System.Drawing.Point(175, 49);
            this.ClientNumberPaymentsField.Name = "ClientNumberPaymentsField";
            this.ClientNumberPaymentsField.Size = new System.Drawing.Size(270, 20);
            this.ClientNumberPaymentsField.TabIndex = 1;
            // 
            // ClientNumber
            // 
            this.ClientNumber.AutoSize = true;
            this.ClientNumber.Location = new System.Drawing.Point(66, 52);
            this.ClientNumber.Name = "ClientNumber";
            this.ClientNumber.Size = new System.Drawing.Size(103, 13);
            this.ClientNumber.TabIndex = 0;
            this.ClientNumber.Text = "Клиентски номер*:";
            // 
            // SignObligationsTab
            // 
            this.SignObligationsTab.Controls.Add(this.SignOblGroupBox);
            this.SignObligationsTab.Location = new System.Drawing.Point(4, 22);
            this.SignObligationsTab.Name = "SignObligationsTab";
            this.SignObligationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SignObligationsTab.Size = new System.Drawing.Size(567, 288);
            this.SignObligationsTab.TabIndex = 1;
            this.SignObligationsTab.Text = "Вписване на задължения";
            this.SignObligationsTab.UseVisualStyleBackColor = true;
            // 
            // SignOblGroupBox
            // 
            this.SignOblGroupBox.Controls.Add(this.ClearSignOblBtn);
            this.SignOblGroupBox.Controls.Add(this.ConfirmSignOblBtn);
            this.SignOblGroupBox.Controls.Add(this.CategoryOblSignOblField);
            this.SignOblGroupBox.Controls.Add(this.ClientNumberSignOblField);
            this.SignOblGroupBox.Controls.Add(this.NameOfOblSignOblField);
            this.SignOblGroupBox.Controls.Add(this.label7);
            this.SignOblGroupBox.Controls.Add(this.label6);
            this.SignOblGroupBox.Controls.Add(this.label1);
            this.SignOblGroupBox.Controls.Add(this.label4);
            this.SignOblGroupBox.Location = new System.Drawing.Point(7, 4);
            this.SignOblGroupBox.Name = "SignOblGroupBox";
            this.SignOblGroupBox.Size = new System.Drawing.Size(554, 284);
            this.SignOblGroupBox.TabIndex = 0;
            this.SignOblGroupBox.TabStop = false;
            this.SignOblGroupBox.Text = "Вписване";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Категория на задължението:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Клиентски номер:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Име на  задължение:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 0;
            // 
            // NameOfOblSignOblField
            // 
            this.NameOfOblSignOblField.Location = new System.Drawing.Point(209, 56);
            this.NameOfOblSignOblField.Name = "NameOfOblSignOblField";
            this.NameOfOblSignOblField.Size = new System.Drawing.Size(257, 20);
            this.NameOfOblSignOblField.TabIndex = 4;
            // 
            // ClientNumberSignOblField
            // 
            this.ClientNumberSignOblField.Location = new System.Drawing.Point(209, 82);
            this.ClientNumberSignOblField.Name = "ClientNumberSignOblField";
            this.ClientNumberSignOblField.Size = new System.Drawing.Size(257, 20);
            this.ClientNumberSignOblField.TabIndex = 5;
            // 
            // CategoryOblSignOblField
            // 
            this.CategoryOblSignOblField.Location = new System.Drawing.Point(209, 106);
            this.CategoryOblSignOblField.Name = "CategoryOblSignOblField";
            this.CategoryOblSignOblField.Size = new System.Drawing.Size(257, 20);
            this.CategoryOblSignOblField.TabIndex = 6;
            // 
            // ConfirmSignOblBtn
            // 
            this.ConfirmSignOblBtn.Location = new System.Drawing.Point(209, 159);
            this.ConfirmSignOblBtn.Name = "ConfirmSignOblBtn";
            this.ConfirmSignOblBtn.Size = new System.Drawing.Size(120, 23);
            this.ConfirmSignOblBtn.TabIndex = 7;
            this.ConfirmSignOblBtn.Text = "Впиши задължение";
            this.ConfirmSignOblBtn.UseVisualStyleBackColor = true;
            // 
            // ClearSignOblBtn
            // 
            this.ClearSignOblBtn.Location = new System.Drawing.Point(347, 159);
            this.ClearSignOblBtn.Name = "ClearSignOblBtn";
            this.ClearSignOblBtn.Size = new System.Drawing.Size(119, 23);
            this.ClearSignOblBtn.TabIndex = 8;
            this.ClearSignOblBtn.Text = "Изчисти";
            this.ClearSignOblBtn.UseVisualStyleBackColor = true;
            // 
            // SignUserTab
            // 
            this.SignUserTab.Controls.Add(this.SignUserGroupBox);
            this.SignUserTab.Location = new System.Drawing.Point(4, 22);
            this.SignUserTab.Name = "SignUserTab";
            this.SignUserTab.Size = new System.Drawing.Size(567, 288);
            this.SignUserTab.TabIndex = 2;
            this.SignUserTab.Text = "Вписване на потребители";
            this.SignUserTab.UseVisualStyleBackColor = true;
            // 
            // InfoFormTab
            // 
            this.InfoFormTab.Controls.Add(this.groupBox3);
            this.InfoFormTab.Location = new System.Drawing.Point(4, 22);
            this.InfoFormTab.Name = "InfoFormTab";
            this.InfoFormTab.Size = new System.Drawing.Size(567, 288);
            this.InfoFormTab.TabIndex = 3;
            this.InfoFormTab.Text = "Информация за задължения";
            this.InfoFormTab.UseVisualStyleBackColor = true;
            // 
            // SignUserGroupBox
            // 
            this.SignUserGroupBox.Controls.Add(this.SignUserClrBtn);
            this.SignUserGroupBox.Controls.Add(this.textBox1);
            this.SignUserGroupBox.Controls.Add(this.SignUserGeneratedClientNumberLabel);
            this.SignUserGroupBox.Controls.Add(this.SignUserButton);
            this.SignUserGroupBox.Controls.Add(this.SignUserEgnField);
            this.SignUserGroupBox.Controls.Add(this.SignUserLastNameField);
            this.SignUserGroupBox.Controls.Add(this.SignUserFirstNameField);
            this.SignUserGroupBox.Controls.Add(this.SignUserEgnLabel);
            this.SignUserGroupBox.Controls.Add(this.SignUserLastNameLabel);
            this.SignUserGroupBox.Controls.Add(this.SignUserFirstNameLabel);
            this.SignUserGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SignUserGroupBox.Name = "SignUserGroupBox";
            this.SignUserGroupBox.Size = new System.Drawing.Size(561, 282);
            this.SignUserGroupBox.TabIndex = 0;
            this.SignUserGroupBox.TabStop = false;
            this.SignUserGroupBox.Text = "Вписване на потребители";
            // 
            // SignUserFirstNameLabel
            // 
            this.SignUserFirstNameLabel.AutoSize = true;
            this.SignUserFirstNameLabel.Location = new System.Drawing.Point(99, 56);
            this.SignUserFirstNameLabel.Name = "SignUserFirstNameLabel";
            this.SignUserFirstNameLabel.Size = new System.Drawing.Size(32, 13);
            this.SignUserFirstNameLabel.TabIndex = 0;
            this.SignUserFirstNameLabel.Text = "Име:";
            // 
            // SignUserLastNameLabel
            // 
            this.SignUserLastNameLabel.AutoSize = true;
            this.SignUserLastNameLabel.Location = new System.Drawing.Point(72, 83);
            this.SignUserLastNameLabel.Name = "SignUserLastNameLabel";
            this.SignUserLastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.SignUserLastNameLabel.TabIndex = 1;
            this.SignUserLastNameLabel.Text = "Фамилия:";
            // 
            // SignUserEgnLabel
            // 
            this.SignUserEgnLabel.AutoSize = true;
            this.SignUserEgnLabel.Location = new System.Drawing.Point(99, 110);
            this.SignUserEgnLabel.Name = "SignUserEgnLabel";
            this.SignUserEgnLabel.Size = new System.Drawing.Size(31, 13);
            this.SignUserEgnLabel.TabIndex = 2;
            this.SignUserEgnLabel.Text = "ЕГН:";
            // 
            // SignUserFirstNameField
            // 
            this.SignUserFirstNameField.Location = new System.Drawing.Point(137, 53);
            this.SignUserFirstNameField.Name = "SignUserFirstNameField";
            this.SignUserFirstNameField.Size = new System.Drawing.Size(240, 20);
            this.SignUserFirstNameField.TabIndex = 3;
            // 
            // SignUserLastNameField
            // 
            this.SignUserLastNameField.Location = new System.Drawing.Point(137, 80);
            this.SignUserLastNameField.Name = "SignUserLastNameField";
            this.SignUserLastNameField.Size = new System.Drawing.Size(240, 20);
            this.SignUserLastNameField.TabIndex = 4;
            // 
            // SignUserEgnField
            // 
            this.SignUserEgnField.Location = new System.Drawing.Point(137, 107);
            this.SignUserEgnField.Name = "SignUserEgnField";
            this.SignUserEgnField.Size = new System.Drawing.Size(240, 20);
            this.SignUserEgnField.TabIndex = 5;
            // 
            // SignUserButton
            // 
            this.SignUserButton.Location = new System.Drawing.Point(137, 172);
            this.SignUserButton.Name = "SignUserButton";
            this.SignUserButton.Size = new System.Drawing.Size(141, 23);
            this.SignUserButton.TabIndex = 6;
            this.SignUserButton.Text = "Вписване на потребител";
            this.SignUserButton.UseVisualStyleBackColor = true;
            // 
            // SignUserGeneratedClientNumberLabel
            // 
            this.SignUserGeneratedClientNumberLabel.AutoSize = true;
            this.SignUserGeneratedClientNumberLabel.Location = new System.Drawing.Point(22, 137);
            this.SignUserGeneratedClientNumberLabel.Name = "SignUserGeneratedClientNumberLabel";
            this.SignUserGeneratedClientNumberLabel.Size = new System.Drawing.Size(108, 13);
            this.SignUserGeneratedClientNumberLabel.TabIndex = 7;
            this.SignUserGeneratedClientNumberLabel.Text = "Ген. Клиент. номер:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 8;
            // 
            // SignUserClrBtn
            // 
            this.SignUserClrBtn.Location = new System.Drawing.Point(285, 172);
            this.SignUserClrBtn.Name = "SignUserClrBtn";
            this.SignUserClrBtn.Size = new System.Drawing.Size(92, 23);
            this.SignUserClrBtn.TabIndex = 9;
            this.SignUserClrBtn.Text = "Изчисти";
            this.SignUserClrBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.InfoOblResultRichBox);
            this.groupBox3.Controls.Add(this.InfoOblClrBtn);
            this.groupBox3.Controls.Add(this.InfoOblGetInfoBtn);
            this.groupBox3.Controls.Add(this.InfoOblCliNumField);
            this.groupBox3.Controls.Add(this.InfoOblEgnField);
            this.groupBox3.Controls.Add(this.InfoOblLastNameField);
            this.groupBox3.Controls.Add(this.InfoOblFirstNameField);
            this.groupBox3.Controls.Add(this.InfoOblEGNLabel);
            this.groupBox3.Controls.Add(this.InfoOblClientNLabel);
            this.groupBox3.Controls.Add(this.InfoOblLNameLabel);
            this.groupBox3.Controls.Add(this.InfoOblFirstNameLabel);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 282);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация за задължения";
            // 
            // InfoOblFirstNameLabel
            // 
            this.InfoOblFirstNameLabel.AutoSize = true;
            this.InfoOblFirstNameLabel.Location = new System.Drawing.Point(117, 38);
            this.InfoOblFirstNameLabel.Name = "InfoOblFirstNameLabel";
            this.InfoOblFirstNameLabel.Size = new System.Drawing.Size(32, 13);
            this.InfoOblFirstNameLabel.TabIndex = 0;
            this.InfoOblFirstNameLabel.Text = "Име:";
            // 
            // InfoOblLNameLabel
            // 
            this.InfoOblLNameLabel.AutoSize = true;
            this.InfoOblLNameLabel.Location = new System.Drawing.Point(90, 64);
            this.InfoOblLNameLabel.Name = "InfoOblLNameLabel";
            this.InfoOblLNameLabel.Size = new System.Drawing.Size(59, 13);
            this.InfoOblLNameLabel.TabIndex = 1;
            this.InfoOblLNameLabel.Text = "Фамилия:";
            // 
            // InfoOblClientNLabel
            // 
            this.InfoOblClientNLabel.AutoSize = true;
            this.InfoOblClientNLabel.Location = new System.Drawing.Point(47, 117);
            this.InfoOblClientNLabel.Name = "InfoOblClientNLabel";
            this.InfoOblClientNLabel.Size = new System.Drawing.Size(101, 13);
            this.InfoOblClientNLabel.TabIndex = 2;
            this.InfoOblClientNLabel.Text = "Клиентски Номер:";
            // 
            // InfoOblEGNLabel
            // 
            this.InfoOblEGNLabel.AutoSize = true;
            this.InfoOblEGNLabel.Location = new System.Drawing.Point(117, 90);
            this.InfoOblEGNLabel.Name = "InfoOblEGNLabel";
            this.InfoOblEGNLabel.Size = new System.Drawing.Size(31, 13);
            this.InfoOblEGNLabel.TabIndex = 3;
            this.InfoOblEGNLabel.Text = "ЕГН:";
            // 
            // InfoOblFirstNameField
            // 
            this.InfoOblFirstNameField.Location = new System.Drawing.Point(155, 35);
            this.InfoOblFirstNameField.Name = "InfoOblFirstNameField";
            this.InfoOblFirstNameField.Size = new System.Drawing.Size(283, 20);
            this.InfoOblFirstNameField.TabIndex = 4;
            // 
            // InfoOblLastNameField
            // 
            this.InfoOblLastNameField.Location = new System.Drawing.Point(155, 61);
            this.InfoOblLastNameField.Name = "InfoOblLastNameField";
            this.InfoOblLastNameField.Size = new System.Drawing.Size(283, 20);
            this.InfoOblLastNameField.TabIndex = 5;
            this.InfoOblLastNameField.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // InfoOblEgnField
            // 
            this.InfoOblEgnField.Location = new System.Drawing.Point(155, 87);
            this.InfoOblEgnField.Name = "InfoOblEgnField";
            this.InfoOblEgnField.Size = new System.Drawing.Size(283, 20);
            this.InfoOblEgnField.TabIndex = 6;
            // 
            // InfoOblCliNumField
            // 
            this.InfoOblCliNumField.Location = new System.Drawing.Point(155, 114);
            this.InfoOblCliNumField.Name = "InfoOblCliNumField";
            this.InfoOblCliNumField.Size = new System.Drawing.Size(283, 20);
            this.InfoOblCliNumField.TabIndex = 7;
            // 
            // InfoOblGetInfoBtn
            // 
            this.InfoOblGetInfoBtn.Location = new System.Drawing.Point(155, 141);
            this.InfoOblGetInfoBtn.Name = "InfoOblGetInfoBtn";
            this.InfoOblGetInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.InfoOblGetInfoBtn.TabIndex = 8;
            this.InfoOblGetInfoBtn.Text = "Изискай";
            this.InfoOblGetInfoBtn.UseVisualStyleBackColor = true;
            // 
            // InfoOblClrBtn
            // 
            this.InfoOblClrBtn.Location = new System.Drawing.Point(363, 140);
            this.InfoOblClrBtn.Name = "InfoOblClrBtn";
            this.InfoOblClrBtn.Size = new System.Drawing.Size(75, 24);
            this.InfoOblClrBtn.TabIndex = 9;
            this.InfoOblClrBtn.Text = "Изчисти";
            this.InfoOblClrBtn.UseVisualStyleBackColor = true;
            // 
            // InfoOblResultRichBox
            // 
            this.InfoOblResultRichBox.Location = new System.Drawing.Point(155, 177);
            this.InfoOblResultRichBox.Name = "InfoOblResultRichBox";
            this.InfoOblResultRichBox.Size = new System.Drawing.Size(283, 92);
            this.InfoOblResultRichBox.TabIndex = 10;
            this.InfoOblResultRichBox.Text = "";
            // 
            // AdministrationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 338);
            this.Controls.Add(this.AdminTab);
            this.Name = "AdministrationPanel";
            this.Text = "Административен панел";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AdminTab.ResumeLayout(false);
            this.PaymentsTab.ResumeLayout(false);
            this.PaymentsGroupBox.ResumeLayout(false);
            this.PaymentsGroupBox.PerformLayout();
            this.SignObligationsTab.ResumeLayout(false);
            this.SignOblGroupBox.ResumeLayout(false);
            this.SignOblGroupBox.PerformLayout();
            this.SignUserTab.ResumeLayout(false);
            this.InfoFormTab.ResumeLayout(false);
            this.SignUserGroupBox.ResumeLayout(false);
            this.SignUserGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AdminTab;
        private System.Windows.Forms.TabPage PaymentsTab;
        private System.Windows.Forms.TabPage SignObligationsTab;
        private System.Windows.Forms.GroupBox PaymentsGroupBox;
        private System.Windows.Forms.TextBox ClientNumberPaymentsField;
        private System.Windows.Forms.Label ClientNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PayAmountPaymentField;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Button ClearPaymentsButton;
        private System.Windows.Forms.Button ConfirmPaymentsButton;
        private System.Windows.Forms.TextBox NameOfObligPaymentsField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdOfObligationPaymentField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox SignOblGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CategoryOblSignOblField;
        private System.Windows.Forms.TextBox ClientNumberSignOblField;
        private System.Windows.Forms.TextBox NameOfOblSignOblField;
        private System.Windows.Forms.Button ClearSignOblBtn;
        private System.Windows.Forms.Button ConfirmSignOblBtn;
        private System.Windows.Forms.TabPage SignUserTab;
        private System.Windows.Forms.TabPage InfoFormTab;
        private System.Windows.Forms.GroupBox SignUserGroupBox;
        private System.Windows.Forms.Label SignUserFirstNameLabel;
        private System.Windows.Forms.Label SignUserEgnLabel;
        private System.Windows.Forms.Label SignUserLastNameLabel;
        private System.Windows.Forms.TextBox SignUserEgnField;
        private System.Windows.Forms.TextBox SignUserLastNameField;
        private System.Windows.Forms.TextBox SignUserFirstNameField;
        private System.Windows.Forms.Button SignUserClrBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label SignUserGeneratedClientNumberLabel;
        private System.Windows.Forms.Button SignUserButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox InfoOblLastNameField;
        private System.Windows.Forms.TextBox InfoOblFirstNameField;
        private System.Windows.Forms.Label InfoOblEGNLabel;
        private System.Windows.Forms.Label InfoOblClientNLabel;
        private System.Windows.Forms.Label InfoOblLNameLabel;
        private System.Windows.Forms.Label InfoOblFirstNameLabel;
        private System.Windows.Forms.TextBox InfoOblCliNumField;
        private System.Windows.Forms.TextBox InfoOblEgnField;
        private System.Windows.Forms.Button InfoOblClrBtn;
        private System.Windows.Forms.Button InfoOblGetInfoBtn;
        private System.Windows.Forms.RichTextBox InfoOblResultRichBox;
    }
}