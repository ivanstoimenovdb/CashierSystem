using System;
using System.Collections.Generic;
using CashSys.Model;
using CashSys.Controller;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierSystem.View
{
    public partial class AdministrationPanel : Form
    {
        public AdministrationPanel()
        {
            InitializeComponent();
        }

        private void SumLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUserButton_Click(object sender, EventArgs e)
        {
            // Create object of type ClientRepository
            ClientRepository client = new ClientRepository();

            // Create Data base context
            var context = new CashierSystemEntities();

            /******************************************************************************************
            **                                   Get field values                                    **
            ******************************************************************************************/
            // Get values of first name field
            var FirstNameClientField = SignUserFirstNameField.Text.ToString();

            // Get values of Last name field
            var LastNameClientField = SignUserLastNameField.Text.ToString();

            // Get values of Egn field
            var EgnClientEgnField = SignUserEgnField.Text.ToString();

           /******************************************************************************************
           **                                   Processing EGN                                      **
           ******************************************************************************************/

            // Cast from string to int
            int EgnInt = int.Parse(EgnClientEgnField);

            var EgnCheck = context.Client.FirstOrDefault(egn => egn.client_egn == EgnInt);

            /******************************************************************************************
            **                      Get from the model generated client number                       **
            ******************************************************************************************/

            var Client = 

            /******************************************************************************************
            **                                   Interact with DB                                    **
            ******************************************************************************************/

            // Check if there is empty field.
            if (FirstNameClientField.Length == 0 || LastNameClientField.Length == 0 || EgnClientEgnField.Length == 0)
            {
                // Thie message shows when fields are empty
                MessageBox.Show("Не сте въвели някое от поле !");
            }
            else if(EgnCheck != null)
            {
                // This message shows when there is Client with such EGN.
                MessageBox.Show("Не може да има човек със същото ЕГН !");
            }else
            {
                client.AddClient(
                    new Client
                    {
                        // Record first name in DB
                        client_first_name = FirstNameClientField,
                       
                        //Record Last name in DB
                        client_last_name = LastNameClientField,

                        // Record Egn in DB
                        client_egn = EgnInt
                    });

                //Clear all fields
                SignUserFirstNameField.Text = "";
                SignUserLastNameField.Text = "";
                SignUserEgnField.Text = "";

                GenClientNSignUser.Text = ClientNumber;

                MessageBox.Show("Успешен запис !");

            }

        }

        private void SignUserFirstNameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUserClrBtn_Click(object sender, EventArgs e)
        {
            /******************************************************************************************
            **                               Clear Button Functionality                              **
            ******************************************************************************************/

            //Clear all fields
            SignUserFirstNameField.Text = "";
            SignUserLastNameField.Text = "";
            SignUserEgnField.Text = "";
        }
    }
}
