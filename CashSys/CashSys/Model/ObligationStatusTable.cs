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
    
    public partial class ObligationStatusTable
    {
        public ObligationStatusTable()
        {
            this.Obligations = new HashSet<Obligations>();
        }
    
        public int status_number { get; set; }
        public int obligation_status { get; set; }
    
        public virtual ICollection<Obligations> Obligations { get; set; }
        public virtual Status Status { get; set; }
    }
}