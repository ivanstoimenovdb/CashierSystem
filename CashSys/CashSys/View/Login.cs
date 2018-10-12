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

            //Get data of Cashier table for user and pass.

            var User = cashier.GetCashier().SingleOrDefault(n => n.cashier_user_name == FieldName && n.cashier_password == FieldPass);

            

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
                if (User != null)
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

            CashierRepository newCashier = new CashierRepository();

          

            var FirstNameReg = NameCashierRegField.Text.ToString();
            var LastNameReg = LnameCashierRegField.Text.ToString();
            var UserNameReg = UserNameCashierRegField.Text.ToString();
            var PassReg = PasswordCashierRegField.Text.ToString();
            var PassConfig = ConfirmPassCashierRegFiedl.Text.ToString();

            var OnlyUserName = newCashier.GetCashier().SingleOrDefault(n => n.cashier_user_name == UserNameReg)  ;



            if (FirstNameReg.Length == 0 || LastNameReg.Length == 0 || UserNameReg.Length == 0 || PassReg.Length == 0 || PassConfig.Length == 0)
            {
                MessageBox.Show("Не сте въвели някое от полетата");
            }
            else
            {
                if (PassReg.Equals(PassConfig))
                {
                    if (OnlyUserName != null)
                    {
                        MessageBox.Show("Такъв потребители.");
                    }
                    else
                    {
                        newCashier.AddCashier(FirstNameReg, LastNameReg, UserNameReg, PassReg);

                        NameCashierRegField.Text = " ";
                        LnameCashierRegField.Text = " ";
                        UserNameCashierRegField.Text = " ";
                        PasswordCashierRegField.Text = " ";
                        ConfirmPassCashierRegFiedl.Text = " ";

                        MessageBox.Show("Успешен запис !");
                    }
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

        private void LoginConteiner_Enter(object sender, EventArgs e)
        {

        }

        private void RegistrationGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ClearButtonReg_Click(object sender, EventArgs e)
        {
            NameCashierRegField.Text = " ";
            LnameCashierRegField.Text = " ";
            UserNameCashierRegField.Text = " ";
            PasswordCashierRegField.Text = " ";
            ConfirmPassCashierRegFiedl.Text = " ";
        }
    }
}
