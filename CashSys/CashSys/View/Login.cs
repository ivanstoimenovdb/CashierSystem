using System;
using CashSys.Controller;
using CashSys.Model;
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


            /******************************************************************************************
            **                                   Get field values                                    **
            ******************************************************************************************/

            //Get String of field.

            var FieldName = UserNameCashierLogField.Text.ToString();

            //Get String of password.

            var FieldPass = PasswordCashierLogField.Text.ToString();

            /******************************************************************************************
            **                                   Get model values                                    **
            ******************************************************************************************/

            //Get data of Cashier table colomn user name.

            var ModelName = cashier.GetCashier();

            //Get data of Cashier table colomn password.

            var ModelPass = cashier.GetCashier();

            /******************************************************************************************
            **                              Check field and model values                             **
            ******************************************************************************************/

            // Checking empty fields

            if (FieldName.Length == 0 || FieldPass.Length == 0)
            {
                MessageBox.Show("Не сте въвели някое от полетата !");
            } 
            else
            {
                if (FieldName.Equals(ModelName) || FieldPass.Equals(ModelPass))
                {
                    // Check model values with fields.
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

        private void ConfirmButtonReg_Click(object sender, EventArgs e)
        {
            var context = new CashierSystemEntities();

            var FirstNameReg = NameCashierRegField.Text.ToString();
            var LastNameReg = LnameCashierRegField.Text.ToString();
            var UserNameReg = UserNameCashierRegField.Text.ToString();
            var PassReg = PasswordCashierRegField.Text.ToString();
            var PassConfig = ConfirmPassCashierRegFiedl.Text.ToString();

            CashierRepository newCashier = new CashierRepository();

            if (FirstNameReg.Length == 0 || LastNameReg.Length == 0 || UserNameReg.Length == 0 || PassReg.Length == 0 || PassConfig.Length == 0)
            {
                MessageBox.Show("Не сте въвели някое от полетата");
            }
            else
            {
                if (PassReg.Equals(PassConfig))
                {
                    newCashier.AddCashier(FirstNameReg, LastNameReg, UserNameReg, PassReg);
                    FirstNameReg = "";
                    LastNameReg = "";
                    UserNameReg = "";
                    PassReg = "";
                    PassConfig = "";
                }
                else
                {
                    MessageBox.Show("Паролите не съвпадат !");
                }
            }
              

        }

        private void LnameCashierRegField_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void PasswordCashierLogField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
