using BClasses;
using DatabaseLayer;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        
        public List<Active> GetAllExpired()
        {
            return dbl.GetAllExpired();
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
        public void SendEmail(string emails,string header, string message1, string message2)
        {
            var emailKey = dbl.GetEmailKey();
            var email = new MimeMessage();
            var sender = new MailboxAddress("Test", emailKey.Email1);
            email.From.Add(sender);
            email.To.Add(MailboxAddress.Parse(emails));
            email.Subject = header;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = $"<h1> {message1} </h1><br> <h1>{message2} </h1>" };
            var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate(emailKey.Email1, emailKey.EmailKey);
            smtp.Send(email);
            smtp.Disconnect(true);
        }
        public List<Item> GetAllItems()
        {
            return dbl.GetAllItems();
        }
        public void Return(ListBoxItem item)
        {
            var returns = dbl.ReturnItem(item);
            dbl.NewLogEntry(DateTime.Now.ToString(), int.Parse(item.Value.Split(',')[1]),returns.personid ,returns.personname , item.Value.Split(',')[0], 2);
        }
    }
}
    