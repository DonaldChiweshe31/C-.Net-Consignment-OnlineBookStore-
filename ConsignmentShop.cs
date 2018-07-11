using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;

        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(x=> x.Sold == false).ToList();
            ItemsListbox.DataSource = itemsBinding;

            ItemsListbox.DisplayMember = "Display";
            ItemsListbox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            ShoppingCartListBox.DataSource = cartBinding;


            ShoppingCartListBox.DisplayMember = "Display";
            ShoppingCartListBox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            Vendorlistbox.DataSource = vendorsBinding;

            Vendorlistbox.DisplayMember = "Display";
            Vendorlistbox.ValueMember = "Display";
        }

        private void SetupData()
        {

            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

            store.Items.Add(new Item
            {
                Title = "Mobby Brown",
                Description = "A book about a whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Nino Brown",
                Description = "A book about the Mafia",
                Price = 3.50M,
                Owner = store.Vendors[1]
            });


            store.Items.Add(new Item
            {
                Title = "Power",
                Description = "A book about New York Hustlers",
                Price = 5.50M,
                Owner = store.Vendors[1]
            });


            store.Items.Add(new Item
            {
                Title = "Prison Break",
                Description = "A book about Life of Prisonment",
                Price = 3.80M,
                Owner = store.Vendors[1]
            });

            store.Name = "Seconds to Rage";
        }
        private void AddToCart_Click(object sender, EventArgs e)
        {

            //Figure out what is selected from the items list
            //copy that item to the shopping cart
            //Do we remover the item from the items list?-no

            Item SelectedItem = (Item)ItemsListbox.SelectedItem;

            shoppingCartData.Add(SelectedItem);

            cartBinding.ResetBindings(false);

        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            //Mark each item in the cart as sold
            //Clear the cart

            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal) item.Owner.Commission *item.Price;
                storeProfit += (1 -(decimal )item.Owner.Commission)*item.Price;
                    
            }
            shoppingCartData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            storeProfitValue.Text = String.Format("${0}", storeProfit);
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }
    }
}
