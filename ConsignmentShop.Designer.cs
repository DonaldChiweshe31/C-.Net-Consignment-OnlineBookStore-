namespace ConsignmentShopUI
{
    partial class ConsignmentShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemsListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.AddToCart = new System.Windows.Forms.Button();
            this.MakePurchase = new System.Windows.Forms.Button();
            this.Vendorlistbox = new System.Windows.Forms.ListBox();
            this.vendorListboxLabel = new System.Windows.Forms.Label();
            this.storePayoutLabe = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemsListbox
            // 
            this.ItemsListbox.FormattingEnabled = true;
            this.ItemsListbox.ItemHeight = 20;
            this.ItemsListbox.Location = new System.Drawing.Point(33, 46);
            this.ItemsListbox.Name = "ItemsListbox";
            this.ItemsListbox.Size = new System.Drawing.Size(232, 224);
            this.ItemsListbox.TabIndex = 0;
            this.ItemsListbox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "StoreItems";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ShoppingCart";
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.ItemHeight = 20;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(471, 46);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(232, 224);
            this.ShoppingCartListBox.TabIndex = 2;
            // 
            // AddToCart
            // 
            this.AddToCart.Location = new System.Drawing.Point(337, 110);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(128, 23);
            this.AddToCart.TabIndex = 4;
            this.AddToCart.Text = "Add To Cart";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // MakePurchase
            // 
            this.MakePurchase.Location = new System.Drawing.Point(610, 276);
            this.MakePurchase.Name = "MakePurchase";
            this.MakePurchase.Size = new System.Drawing.Size(93, 23);
            this.MakePurchase.TabIndex = 5;
            this.MakePurchase.Text = "Purchase";
            this.MakePurchase.UseVisualStyleBackColor = true;
            this.MakePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // Vendorlistbox
            // 
            this.Vendorlistbox.FormattingEnabled = true;
            this.Vendorlistbox.ItemHeight = 20;
            this.Vendorlistbox.Location = new System.Drawing.Point(33, 313);
            this.Vendorlistbox.Name = "Vendorlistbox";
            this.Vendorlistbox.Size = new System.Drawing.Size(232, 224);
            this.Vendorlistbox.TabIndex = 6;
            // 
            // vendorListboxLabel
            // 
            this.vendorListboxLabel.AutoSize = true;
            this.vendorListboxLabel.Location = new System.Drawing.Point(38, 290);
            this.vendorListboxLabel.Name = "vendorListboxLabel";
            this.vendorListboxLabel.Size = new System.Drawing.Size(98, 20);
            this.vendorListboxLabel.TabIndex = 7;
            this.vendorListboxLabel.Text = "StoreItems";
            // 
            // storePayoutLabe
            // 
            this.storePayoutLabe.AutoSize = true;
            this.storePayoutLabe.Location = new System.Drawing.Point(352, 313);
            this.storePayoutLabe.Name = "storePayoutLabe";
            this.storePayoutLabe.Size = new System.Drawing.Size(137, 20);
            this.storePayoutLabe.TabIndex = 8;
            this.storePayoutLabe.Text = "storeProfitLabel";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Location = new System.Drawing.Point(514, 313);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(54, 20);
            this.storeProfitValue.TabIndex = 9;
            this.storeProfitValue.Text = "$0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storePayoutLabe);
            this.Controls.Add(this.vendorListboxLabel);
            this.Controls.Add(this.Vendorlistbox);
            this.Controls.Add(this.MakePurchase);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShoppingCartListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemsListbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ConsignmentShop";
            this.Text = "ConsignmentShop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemsListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ShoppingCartListBox;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.Button MakePurchase;
        private System.Windows.Forms.ListBox Vendorlistbox;
        private System.Windows.Forms.Label vendorListboxLabel;
        private System.Windows.Forms.Label storePayoutLabe;
        private System.Windows.Forms.Label storeProfitValue;
    }
}

