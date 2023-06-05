
using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Threading;

using System.Windows.Forms;
using System.Linq;
using System.Windows.Controls;
using BLayer;
using BClasses;
using ListBoxItem = BClasses.ListBoxItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Utlan
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var bl = new BL();
            var items = bl.GetAllItems();
            Items.DisplayMember = "Text";
            Items.ValueMember = "Value";
            items.ForEach(x => {
                Items.Items.Add(new ListBoxItem
                {
                    Text = x.ITEMNAME,
                    Value = x.ITEMID.ToString()
                }); 
            });

        }

        private void RegisterReturn_Click(object sender, EventArgs e)
        {
            var selecteditems = RegisteredItems.CheckedItems.Cast<ListBoxItem>().ToList();
            var bl = new BL();
            selecteditems.ForEach(x => {
                bl.Return(x);
            });
            RegisteredItems.Items.Clear();
            var email = TextBoxID.Text.ToLower().Trim();
            var items = bl.GetBorrowedItems(email);
            items.ForEach(x => { RegisteredItems.Items.Add(new ListBoxItem { Text = bl.ItemIDToItemName(x.ITEMID) + ".  Expiration:" + x.DATE.AddDays(30).ToString("dd/MM/yyyy"), Value = x.TRANSACTIONID + "," + x.ITEMID }); });
        }
        private void RegisterID_Click(object sender, EventArgs e)
        {
            IDText.Focus();
            IDText.ReadOnly = false;
        }


        private void Returnere(object sender, EventArgs e)
        {
            ChangeVisibility(false);
        }

        private void Utlan(object sender, EventArgs e)
        {
            ChangeVisibility(true);
        }
        private void ChangeVisibility(bool b)
        {
            label4.Visible = b;
            Items.Visible = b;
            Navn.Visible = b;
            label1.Visible = b;
            label2.Visible = b;
            IDText.Visible = b;
            RegisterBorrow.Visible = b;
            RegisterItemReturn.Visible = !b;
            label3.Visible = !b;
            TextBoxID.Visible = !b;
            RegisterReturn.Visible = !b;
            RegisteredItems.Visible = !b;
        }

        private void RegisterItemReturn_Click(object sender, EventArgs e)
        {
            var email = TextBoxID.Text.ToLower().Trim();
            var bl = new BL();
            var scl = bl.EmailExists(email);
            if (scl == null)
            {
                ShowError("Email does not exist.", false);
                return;
            }
            RegisteredItems.Items.Clear();
            RegisteredItems.DisplayMember = "Text";
            RegisteredItems.ValueMember = "Value";
            var items = bl.GetBorrowedItems(email);
            items.ForEach(x => { RegisteredItems.Items.Add(new ListBoxItem { Text = bl.ItemIDToItemName(x.ITEMID)+".  Expiration:"+x.DATE.AddDays(30).ToString("dd/MM/yyyy"), Value = x.TRANSACTIONID+","+x.ITEMID }); });

        }
        private void IDText_Leave(object sender, EventArgs e)
        {
            var bl = new BL();
            var email = IDText.Text;
            var result = bl.EmailExists(email);
            Navn.Text = result ?? "";
            Navn.ReadOnly = Navn.Text.Length > 0;
        }


        private void RegisterBorrow_Click(object sender, EventArgs e)
        {
            var name = Navn.Text;
            var transactionid = Guid.NewGuid().ToString();
            var personid = IDText.Text;
            var selecteditems = Items.CheckedItems.Cast<ListBoxItem>();
            var bl = new BL();
            var l = new List<int>();
            selecteditems.ToList().ForEach(x => {
                l.Add(bl.ItemNameToItemID(x.Text));
            });
            var transactiondate = DateTime.Now.ToString();
            if (!l.Any())
            {
                ShowError("You did not select any items.", false);
                return;
            }
            if (!bl.NewLogEntry(transactiondate, l, personid, name, transactionid, 1))
            {
                ShowError("Error while registering, please try again", false);
                return;
            }
            ShowError("Successfully Registered Item.", true);
        }
        private void ErrorDisappear(bool success)
        {

            Thread.Sleep(1000);
            if (success)
            {
                Error.Visible = false;
                IDText.Text = "";
                Navn.Text = "";
                RegisteredItems.ClearSelected();
                return;
            }
            Error.Visible = false;

        }

        private void ShowError(string text, bool success)
        {
            Error.Visible = true;
            Error.Text = text;
            var disappear = new Thread(() => ErrorDisappear(success));
            disappear.Start();
        }
        

    }
}