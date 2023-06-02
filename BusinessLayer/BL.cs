using BClasses;
using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLayer
{
    
    public class BL
    {
        public static DBLS dbl = new DBLS();
        public bool NewLogEntry(string transactiondate, List<int> itemid, string personid, string name, string transactionid, int type)
        {
            if (itemid.Count() == 0)
                return false;
            if (string.IsNullOrEmpty(name))
                return false;
            itemid.ToList().ForEach(item => {
                dbl.NewLogEntry(transactiondate, item, personid, name, transactionid, type);
                dbl.RegisterBorrow(transactiondate, item, personid, name, transactionid);
            });
            return true;
        }
        public string EmailExists(string email)
        {
            return dbl.EmailExists(email);
        }
        public int ItemNameToItemID(string name)
        {
            return dbl.ItemNameToItemID(name);
        }
        public List<Active> GetBorrowedItems(string email)
        {
            return dbl.GetBorrowedItems(email);
        }
        public string ItemIDToItemName(int id)
        {
            return dbl.ItemIDToItemName(id);
        }
        public List<Item> GetAllItems()
        {
            return dbl.GetAllItems();
        }
        public void Return(ListBoxItem item)
        {
            var returns = dbl.ReturnItem(item);
            dbl.NewLogEntry(DateTime.Now.ToString(), int.Parse(item.Value.Split(',')[1]),returns.personid ,returns.personname , item.Value.Split(',')[0], 1);
        }
    }
}
    