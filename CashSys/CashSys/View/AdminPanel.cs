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

            

            /******************************************************************************************
            **                                   Interact with DB                                    **
            ******************************************************************************************/

            // Check if there is empty field.
            if (FirstNameClientField.Length == 0 || LastNameClientField.Length == 0 || EgnClientEgnField.Length == 0)
            {
                // Thie message shows when fields are empty
                MessageBox.Show("Не сте въвели някое от поле !");
            }
            else if (EgnCheck != null)
            {
                // This message shows when there is Client with such EGN.
                MessageBox.Show("Не може да има човек със същото ЕГН !");
            }
            else
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
                var ClientNumber = context.Client.FirstOrDefault(c => c.client_egn == EgnInt).client_serial_number;

                //Clear all fields
                SignUserFirstNameField.Text = "";
                SignUserLastNameField.Text = "";
                SignUserEgnField.Text = "";

                GenClientNSignUser.Text = ClientNumber.ToString();

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

        private void ConfirmSignOblBtn_Click(object sender, EventArgs e)
        {
            /******************************************************************************************
            **                                 Get fields in values                                  **
            ******************************************************************************************/

            // Get values of NameOfOblSignOblField
            var oblName = NameOfOblSignOblField.Text;

            // Get values of ClientNumberSignOblField
            var clientNumber = int.Parse(ClientNumberSignOblField.Text);

            // Get values of CategoryOblSignOblField
            var category = CategoryOblSignOblField.Text;

            // Get values of HasToPaidFieldSignObl
            var hasPayde = decimal.Parse(HasToPaidFieldSignObl.Text);

            /******************************************************************************************
            **                                   Create Services                                     **
            ******************************************************************************************/

            // Create client service
            ClientRepository client = new ClientRepository();

            // Create Obligation service
            ObligationsRepository obl = new ObligationsRepository();

            
            var currentClient = client.GetClients().FirstOrDefault(c => c.client_serial_number
             == clientNumber);

            currentClient.Obligations.Add(
                obl.AddObligations(new Obligations
                {
                    Category = new Category()
                    {
                        category_name = category
                    },
                    obligation_name = oblName,
                    obligation_payments = hasPayde
                })
                    );

            NameOfOblSignOblField.Text = "";
            ClientNumberSignOblField.Text = "";
            CategoryOblSignOblField.Text = "";
            HasToPaidFieldSignObl.Text = "";

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmPaymentsButton_Click(object sender, EventArgs e)
        {
            {
                /******************************************************************************************
                **                                 Get fields in values                                  **
                ******************************************************************************************/

                // getting values in lientNumberPaymentsField
                var clientNumber = int.Parse(ClientNumberPaymentsField.Text);

                // getting values in PayAmountPaymentField
                var paymentSum = decimal.Parse(PayAmountPaymentField.Text);

                // getting values IdOfObligation field
                var numOfObligation = int.Parse(IdOfObligationPaymentField.Text);

                // getting values NameOfObligPaymentsField
                var nameOfObl = NameOfObligPaymentsField.Text;

                /******************************************************************************************
                **                                  Create Repository                                    **
                ******************************************************************************************/

                // Creating repository of client 
                ClientRepository client = new ClientRepository();

                // Creating repository of obligation
                ObligationsRepository obligation = new ObligationsRepository();

                // Creating repository of payment
                PaymentsRepository payment = new PaymentsRepository();

                /******************************************************************************************
                **                            Processing of obligation and user                          **
                ******************************************************************************************/

                // Get current obligation
                var currentObl = obligation.GetObligations().FirstOrDefault(o => o.obligation_number == numOfObligation);

                // Get current user
                var currentCli = client.GetClients().FirstOrDefault(c => c.client_serial_number == clientNumber);

                // Check if fields are empty
                if (ClientNumberPaymentsField.Text.Length == 0 || PayAmountPaymentField.Text.Length == 0 || IdOfObligationPaymentField.Text.Length == 0 || NameOfObligPaymentsField.Text.Length == 0)
                {
                    MessageBox.Show("Не сте въвели някое от полетата");
                }
                else { 
                // Adding a payments
                currentObl.payments.Add(payment.AddPayments(new payments
                {
                    amount_of_payment = paymentSum,
                    date_of_payment = DateTime.Now.Date
                }
                ));

                // Checking if client exists it will add obligation
                if (currentCli?.Obligations.FirstOrDefault(o => o.obligation_number == numOfObligation) == null)
                {
                    // Add obligation in the client
                    currentCli.Obligations.Add(
                    currentObl);
                }
                else
                {
                    // getting obligation number as index
                    var index = currentCli.Obligations.ToList().IndexOf(
                                currentCli.Obligations.ToList().FirstOrDefault(
                                o => o.obligation_number == numOfObligation));

                    // remove old obligation 
                    currentCli.Obligations.ToList().RemoveAt(index);

                    // add new obligation
                    currentCli.Obligations.ToList().Insert(
                       index, currentObl);
                    }
                }
            }
        }

        private void InfoOblGetInfoBtn_Click(object sender, EventArgs e)
        {
            /******************************************************************************************
            **                            Processing of obligation and user                          **
            ******************************************************************************************/

            // Client repository 
            ClientRepository client = new ClientRepository();

            /******************************************************************************************
            **                                 Get fields in values                                  **
            ******************************************************************************************/
            // get client number
            var ClientNumber = int.Parse(InfoOblCliNumField.Text);

            /******************************************************************************************
            **                                     Processing                                        **
            ******************************************************************************************/
            var temp = client.GetClients().
                FirstOrDefault(c => c.client_serial_number == ClientNumber).
                Obligations;

            
            foreach (var row in temp)
            {
                InfoOblResultRichBox.Text += row.obligation_number + "\t" + row.obligation_name + "\t" + row.Category.category_name;
            }
            
        }
    }
}   
