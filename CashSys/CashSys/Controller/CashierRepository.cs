using System;
using CashSys.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashSys.Controller
{
    /**********************************************************************
   **        This Class is responsible for Obligation Repository        ** 
   **********************************************************************/

    class CashierRepository
    {
      
        //This Mehtod get all cahiers and returns  list of type Cashier.

        public List<Cashier> GetCashier()
        {
            var context = new CashierSystemEntities();

            var cashier = context.Cashier.ToList();
            

            return cashier;
        }

        //This Method add object of type Cashier to the table Cashier.


        public void AddCashier(string FirstName, string LastName, string userName, string Pass)
        {
            var context = new CashierSystemEntities();

            var include = context.Cashier.Include("CashierClientTable").Where(x => x.cashier_user_name == userName);

            
            Cashier newCashier = context.Cashier.Add
                (
                new Cashier
                {
                    cashier_first_name = FirstName,
                    cashier_last_name = LastName,
                    cashier_user_name = userName,
                    cashier_password = Pass

                }
                );
            
     

            context.SaveChanges();
        }

        //This Method Attach object of type Cashier to the context.

        public void UpdateCashier(Cashier cashier)
        {
            var context = new CashierSystemEntities();

            context.Cashier.Attach(cashier);

            context.SaveChanges();
        }



    }
}
