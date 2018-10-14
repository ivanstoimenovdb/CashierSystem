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

            //Get whole data of user (user name and pass).

            var UserNamePass = cashier.GetCashier().FirstOrDefault(x => x.cashier_user_name == FieldName && x.cashier_password == FieldPass);

            /******************************************************************************************
            **                                   Log in proccessing                                  **
            ******************************************************************************************/

            // Checking empty fields

            if (FieldName.Length == 0 || FieldPass.Length == 0)
            {
                MessageBox.Show("Не сте въвели някое от полетата !");
            } 
            else
            {
                // Check user name and pass.

                if (UserNamePass != null)
                {
                    //If there are user name and password. Program will proceed to Admin panel.

                    this.Hide();
                    AdministrationPanel adminPanel = new AdministrationPanel();
                    adminPanel.ShowDialog();
                }
                else
                {
                    //Else message will show

                    MessageBox.Show("Въвели сте грешен user name или парола !");
                }
            }
            

        }

        private void ConfirmButtonReg_Click(object sender, EventArgs e)
        {
            var context = new CashierSystemEntities();

            /******************************************************************************************
            **                           Getting  values in registration form                        **
            ******************************************************************************************/

            // Get value in registration form – text field first name.
            var FirstNameReg = NameCashierRegField.Text.ToString();

            // Get value in registration form – text field last name.
            var LastNameReg = LnameCashierRegField.Text.ToString();

            // Get value in registration form – text field user name.
            var UserNameReg = UserNameCashierRegField.Text.ToString();

            // Get value in registration form – text field password.
            var PassReg = PasswordCashierRegField.Text.ToString();

            // Get value in registration form – text field confirm password.
            var PassConfig = ConfirmPassCashierRegFiedl.Text.ToString();

            /******************************************************************************************
            **                                   Getting data model                                  **
            ******************************************************************************************/

            // Object newCashier of type CashierRepository.
            CashierRepository newCashier = new CashierRepository();

            // Get only user name from table Cashier.
            var onlyUserName = context.Cashier.FirstOrDefault(un => un.cashier_user_name == UserNameReg);

            /******************************************************************************************
            **                                Registration proccessing                               **
            ******************************************************************************************/

            // Check if any field is empty. 
            if (FirstNameReg.Length == 0 || LastNameReg.Length == 0 || UserNameReg.Length == 0 || PassReg.Length == 0 || PassConfig.Length == 0)
            {
                // If there is empty field, it shows message.
                MessageBox.Show("Не сте въвели някое от полетата!");
            }
            else
            {
                // Check password and confirm password match. 
                if (PassReg.Equals(PassConfig))
                {
                    // Check is user exist
                    if (onlyUserName != null)
                    {
                        // Return message that user exists
                        MessageBox.Show("Съществува такъв потребител ! Сменете потребителското име");

                    }else
                    {
                        // Add to table new cashier
                        newCashier.AddCashier(FirstNameReg, LastNameReg, UserNameReg, PassReg);

                        // Clear all fields
                        NameCashierRegField.Text = "";
                        LnameCashierRegField.Text = "";
                        UserNameCashierRegField.Text = "";
                        PasswordCashierRegField.Text = "";
                        ConfirmPassCashierRegFiedl.Text = "";

                        // Confirmed record 
                        MessageBox.Show("Успешен запис !");
                    }
                }
                else
                {
                    // If there is no matching of confirm pass and pass, shows message.
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

        private void ClearButtonReg_Click(object sender, EventArgs e)
        {
            /******************************************************************************************
            **                               Clear Button Functionality                              **
            ******************************************************************************************/

            // Clear all fields

            NameCashierRegField.Text = "";
            LnameCashierRegField.Text = "";
            UserNameCashierRegField.Text = "";
            PasswordCashierRegField.Text = "";
            ConfirmPassCashierRegFiedl.Text = "";
        }
    }
}
