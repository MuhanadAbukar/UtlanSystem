using System.Windows.Forms;

namespace Utlan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IDText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegisterBorrow = new System.Windows.Forms.Button();
            this.RegisterReturn = new System.Windows.Forms.Button();
            this.RegisterItemReturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.RegisteredItems = new System.Windows.Forms.CheckedListBox();
            this.Navn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Items = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(383, 50);
            this.IDText.Multiline = true;
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(222, 20);
            this.IDText.TabIndex = 0;
            this.IDText.Visible = false;
            this.IDText.Leave += new System.EventHandler(this.IDText_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.label1.Location = new System.Drawing.Point(383, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-Post";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label2.Location = new System.Drawing.Point(383, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            this.label2.Visible = false;
            // 
            // RegisterBorrow
            // 
            this.RegisterBorrow.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.RegisterBorrow.Location = new System.Drawing.Point(563, 371);
            this.RegisterBorrow.Name = "RegisterBorrow";
            this.RegisterBorrow.Size = new System.Drawing.Size(142, 48);
            this.RegisterBorrow.TabIndex = 6;
            this.RegisterBorrow.Text = "Registrer utlån";
            this.RegisterBorrow.UseVisualStyleBackColor = true;
            this.RegisterBorrow.Visible = false;
            this.RegisterBorrow.Click += new System.EventHandler(this.RegisterBorrow_Click);
            // 
            // RegisterReturn
            // 
            this.RegisterReturn.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.RegisterReturn.Location = new System.Drawing.Point(317, 371);
            this.RegisterReturn.Name = "RegisterReturn";
            this.RegisterReturn.Size = new System.Drawing.Size(142, 48);
            this.RegisterReturn.TabIndex = 13;
            this.RegisterReturn.Text = "Returner varen";
            this.RegisterReturn.UseVisualStyleBackColor = true;
            this.RegisterReturn.Visible = false;
            this.RegisterReturn.Click += new System.EventHandler(this.RegisterReturn_Click);
            // 
            // RegisterItemReturn
            // 
            this.RegisterItemReturn.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.RegisterItemReturn.Location = new System.Drawing.Point(213, 224);
            this.RegisterItemReturn.Name = "RegisterItemReturn";
            this.RegisterItemReturn.Size = new System.Drawing.Size(142, 48);
            this.RegisterItemReturn.TabIndex = 11;
            this.RegisterItemReturn.Text = "Finn lånte varer";
            this.RegisterItemReturn.UseVisualStyleBackColor = true;
            this.RegisterItemReturn.Visible = false;
            this.RegisterItemReturn.Click += new System.EventHandler(this.RegisterItemReturn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label3.Location = new System.Drawing.Point(33, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 40);
            this.label3.TabIndex = 10;
            this.label3.Text = "Epost";
            this.label3.Visible = false;
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(33, 224);
            this.TextBoxID.Multiline = true;
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(168, 33);
            this.TextBoxID.TabIndex = 8;
            this.TextBoxID.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.button3.Location = new System.Drawing.Point(188, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 48);
            this.button3.TabIndex = 14;
            this.button3.Text = "Utlån";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Utlan);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.button5.Location = new System.Drawing.Point(33, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 48);
            this.button5.TabIndex = 15;
            this.button5.Text = "Returnere";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Returnere);
            // 
            // Error
            // 
            this.Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Error.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Error.Location = new System.Drawing.Point(406, 330);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(319, 38);
            this.Error.TabIndex = 16;
            this.Error.Text = "successfully registered item";
            this.Error.Visible = false;
            // 
            // RegisteredItems
            // 
            this.RegisteredItems.FormattingEnabled = true;
            this.RegisteredItems.Location = new System.Drawing.Point(33, 295);
            this.RegisteredItems.Name = "RegisteredItems";
            this.RegisteredItems.Size = new System.Drawing.Size(278, 109);
            this.RegisteredItems.TabIndex = 17;
            this.RegisteredItems.Visible = false;
            // 
            // Navn
            // 
            this.Navn.Location = new System.Drawing.Point(383, 130);
            this.Navn.Multiline = true;
            this.Navn.Name = "Navn";
            this.Navn.Size = new System.Drawing.Size(222, 20);
            this.Navn.TabIndex = 18;
            this.Navn.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.label4.Location = new System.Drawing.Point(383, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Full navn";
            this.label4.Visible = false;
            // 
            // Items
            // 
            this.Items.FormattingEnabled = true;
            this.Items.Location = new System.Drawing.Point(383, 213);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(175, 109);
            this.Items.TabIndex = 20;
            this.Items.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 429);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Navn);
            this.Controls.Add(this.RegisteredItems);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RegisterReturn);
            this.Controls.Add(this.RegisterItemReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.RegisterBorrow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox IDText;
        private Label label1;
        private Label label2;
        private Button RegisterBorrow;
        private Button RegisterReturn;
        private Button RegisterItemReturn;
        private Label label3;
        private TextBox TextBoxID;
        private Button button3;
        private Button button5;
        private Label Error;
        private CheckedListBox RegisteredItems;
        private TextBox Navn;
        private Label label4;
        private CheckedListBox Items;
    }
}