using BClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{

    public class DBLS
    {
        private static string connstr = "Data Source=itaserver;Initial Catalog=UtlånMuhanad;Persist Security Info=True;User ID=muhanadharvester;Password=muhanad123";
        private static SqlConnection conn = new SqlConnection(connstr);
        public bool NewLogEntry(string transactiondate, int itemid, string personid, string name, string transactionid, int type)
        {
            var model = new EFModel();
            var id = model.Logs.Count() == 0 ? 1 : model.Logs.Max(x => x.EFID);
            var log = new Log()
            {
                TRANSACTIONID = transactionid,
                TRANSACTIONDATE = transactiondate,
                ITEMID = itemid,
                TRANSACTIONTYPE = type,
                PERSONID = personid,
                PERSONNAME = name,
                EFID = id + 1
            };

            try
            {
                model.Logs.Add(log);
                model.SaveChanges();
                return true;
            }
            catch (InvalidOperationException)
            {
                return false;
            }
        }
        public List<Active> GetAllExpired()
        {
            var c = new EFModel();
            var thirtyDaysAgo = DateTime.Now.AddDays(-30);
            var expired = c.Actives.Where(x => x.DATE > thirtyDaysAgo).ToList();
            return expired;
        }
        public Email GetEmailKey()
        {
            var c = new EFModel();
            return c.Emails.First();
        }
        public Person ReturnItem(ListBoxItem item)
        {
            var ef = new EFModel();
            var values = item.Value.Split(',');
            var transactionid = values[0];
            var itemid = int.Parse(values[1]);
            var active = ef.Actives.FirstOrDefault(x => x.TRANSACTIONID == transactionid && x.ITEMID == itemid);
            ef.Actives.Remove(active);
            ef.SaveChanges();
            return new Person {personid=active.PERSONID,personname=active.PERSONNAME};
        }
        public int ItemNameToItemID(string name)
        {
            var c = new EFModel();
            return c.Items.FirstOrDefault(x => x.ITEMNAME == name).ITEMID;
        }
        public string ItemIDToItemName(int id)
        {
            var c = new EFModel();
            return c.Items.FirstOrDefault(x => x.ITEMID == id).ITEMNAME;
        }
        public void RegisterBorrow(string transactiondate, int itemid, string personid, string name, string transactionid)
        {
            var model = new EFModel();
            var active = new Active()
            {
                TRANSACTIONID = transactionid,
                DATE = DateTime.Parse(transactiondate),
                ITEMID = itemid,
                PERSONID = personid,
                PERSONNAME = name
            };
            model.Actives.Add(active);
            model.SaveChanges();
        }
        public List<Item> GetAllItems()
        {
            var mdl = new EFModel();
            return mdl.Items.ToList();
        }
        public string EmailExists(string email)
        {
            var c = new EFModel();
            var found = c.Logs.FirstOrDefault(x => x.PERSONID == email);
            return found != null ? found.PERSONNAME : string.Empty;
        }
        public List<Active> GetBorrowedItems(string email)
        {
            var con = new EFModel();
            var x1 = con.Actives.Where(x => x.PERSONID == email).ToList();
            return x1;
        }
    }
}
