using BClasses;
using BLayer;
using DatabaseLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UtlånChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bl = new BL();
            var config = LoadConfiguration();
            while (true)
            {
                var expired = bl.GetAllExpired();

                foreach (var elev in expired)
                {
                    SendExpirationEmails(bl, elev, config.Admins);
                    Console.WriteLine(elev.PERSONNAME);
                    
                    Thread.Sleep(1500);
                }
                Thread.Sleep(600000);
            }

            
        }
        private static AdminData LoadConfiguration()
        {
            var jsonString = File.ReadAllText("config.json");
            return JsonConvert.DeserializeObject<AdminData>(jsonString);
        }

        private static void SendExpirationEmails(BL bl, Active expiredItem, List<Admin>adminData)
        {
            var itemName = bl.ItemIDToItemName(expiredItem.ITEMID);
            var messageSubject = $"Angående 2ITA Bibliotek";
            var messageBody = $"Hei, {expiredItem.PERSONNAME}, Du har glemt å levere {itemName}. Vennligst lever den så fort som mulig.";
            Console.WriteLine(expiredItem.PERSONNAME);
            bl.SendEmail(expiredItem.PERSONID, messageSubject, messageBody,"");

            Thread.Sleep(1500);

            foreach (var admin in adminData)
            {
                Console.WriteLine(admin.Name);
                var adminSubject = $"{expiredItem.PERSONNAME} har ikke levert en {itemName}";
                var adminBody = $"Navnet til eleven er {expiredItem.PERSONNAME}";
                bl.SendEmail(admin.Email, adminSubject, adminBody,"");
                Thread.Sleep(1500);
            }
        }

    }
}
