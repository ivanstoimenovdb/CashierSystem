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
    
    public partial class Obligations
    {
        public Obligations()
        {
            this.Client = new HashSet<Client>();
            this.payments = new HashSet<payments>();
        }
    
        public int obligation_number { get; set; }
        public int obligation_category_id { get; set; }
        public string obligation_name { get; set; }
        public string obligation_note { get; set; }
        public decimal obligation_payments { get; set; }
        public Nullable<int> obligation_status_id { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ObligationStatusTable ObligationStatusTable { get; set; }
        public virtual ICollection<Client> Client { get; set; }
        public virtual ICollection<payments> payments { get; set; }
    }
}
