//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public Transaction()
        {
            this.Logs = new HashSet<Log>();
        }
    
        public int TRANSACTIONTYPE { get; set; }
        public string TRANSACTIONNAME { get; set; }
    
        public virtual ICollection<Log> Logs { get; set; }
    }
}
