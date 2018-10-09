using CashSys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CashSys.Controller
{
    /***********************************************************************
    **          This Class is responsible for Client Repository          ** 
    **********************************************************************/

    class ClientRepository
    {
        //This Mehtod get all clients and returns  list of type Client.

        public List<Client> GetClients()
        {
            var context = new CashierSystemEntities();

            var client = context.Client.ToList();

            return client;
        }

        //This Method add object of type Client to the table Client.

        public Client AddClient(Client client)
        {
            var context = new CashierSystemEntities();

            context.Client.Add(client);

            context.SaveChanges();

            return client;
        }

        //This Method Attach object of type Client to the context.

        public void UpdateClient(Client client)
        {
            var context = new CashierSystemEntities();

            context.Client.Attach(client);

            context.SaveChanges();
        }


    }
}
