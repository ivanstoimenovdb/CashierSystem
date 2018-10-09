﻿using System;
using CashSys.Controller;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashierSystem.View;

namespace CashierSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void SubmitButtonLog_Click(object sender, EventArgs e)
        {
            CashierRepository cashier = new CashierRepository();

            var ModelName = cashier.GetCashier().Select(n => n.cashier_user_name);
            var ModelPass = cashier.GetCashier().Select(p => p.cashier_password);

            var FieldName = UserNameCashierLogField.Text.ToString();
            var FieldPass = PasswordCashierLogField.Text.ToString();

       
            if (FieldName.Length == 0 && FieldPass.Length == 0)
            {
                MessageBox.Show("Не сте въвели някое от полетата !");
            }
            else if (FieldName.Equals(ModelName) && FieldPass.Equals(ModelPass))
            {
                this.Hide();
                AdministrationPanel adminPanel = new AdministrationPanel();
                adminPanel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Въвели сте грешен user name или парола !");
            }

        }
    }
}
