//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CashSys.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        public Client()
        {
            this.Obligations = new List<Obligations>();
            this.Cashier = new List<Cashier>();
        }
    
        public int client_serial_number { get; set; }
        public int client_egn { get; set; }
        public string client_first_name { get; set; }
        public string client_last_name { get; set; }
    
        public virtual ICollection<Obligations> Obligations { get; set; }
        public virtual ICollection<Cashier> Cashier { get; set; }
    }
}
