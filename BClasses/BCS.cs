using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BClasses
{
    public class Items
    {
        public string ID { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string TransactionID { get; set; }
    }
    public class ListBoxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
    public class Person
    {
        public string personid { get; set; }
        public string personname { get; set; }
    }

    public class Admin
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class AdminData
    {
        public List<Admin> Admins { get; set; }
    }
}
