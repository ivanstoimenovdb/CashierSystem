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

    class ObligationsRepository
    {
        //This Mehtod get all obligations and returns  list of type Obligations.

        public List<Obligations> GetObligations()
        {
            var contex = new CashierSystemEntities();
      
            var obligation = contex.Obligations.ToList();

            return obligation;

        }

        //This Method add object of type Obligations to the table Obligations.

        public Obligations AddObligations(Obligations obligation)
        {
            var context = new CashierSystemEntities();

            context.Obligations.Add(obligation);

            context.SaveChanges();

            return obligation;
        }

        //This Method Attach object of type Obligations to the context.

        public void UpdateObligations(Obligations obligation)
        {
            var context = new CashierSystemEntities();

            context.Obligations.Attach(obligation);

            context.SaveChanges();
        }
   
    }
}
