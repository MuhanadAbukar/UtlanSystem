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
    
    public partial class Item
    {
        public Item()
        {
            this.Logs = new HashSet<Log>();
        }
    
        public int ITEMID { get; set; }
        public string ITEMNAME { get; set; }
    
        public virtual ICollection<Log> Logs { get; set; }
    }
}
