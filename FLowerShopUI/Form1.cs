using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FLowerShop;


namespace FLowerShopUI
{
    public partial class Form1 : Form
    {
        private FlowerCatalog catalog;
        private Cart checkoutCart;
        public Form1()
        {
            InitializeComponent();
            InitializedStore();
            SetSubTotal();
        }
        private void InitializedStore()
        {
            catalog = new FlowerCatalog();
            catalog.loadDataFromXml();
            checkoutCart = new Cart(catalog);
            addFLowerToListBox();
            

        }
        private void SetSubTotal()
        {
            subtotalBox.Text = checkoutCart.GetSubtotal().ToString("0.##");

        }
        private void SetTotal()
        {
            totalBox.Text = checkoutCart.GetTotal().ToString("0.##");

        }
        private void addFLowerToListBox()
        {
            List<string> flowerNameList = catalog.DisplayListOfFLower();
            flowerListBox.DataSource = flowerNameList;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void AddItemToCart(String flower)
        {
            int index = Int32.Parse(flower.Split(':')[0]);
            checkoutCart.AddNewItemToCart(index);
        }
        public void RemoveFlowerFromCart(string flower)
        {
            int index = Int32.Parse(flower.Split(':')[0]);
            checkoutCart.removeItemFromCart(index);
        }
        private void flowerListBox_DoubleClick(object sender, EventArgs e)
        {
            cartListBox.Items.Add(flowerListBox.SelectedItem);
            AddItemToCart(flowerListBox.SelectedItem.ToString());
            SetSubTotal();

        }
        private void cartListBox_DoubleClick(object sender, EventArgs e)
        {
            RemoveFlowerFromCart(cartListBox.SelectedItem.ToString());
            cartListBox.Items.Remove(cartListBox.SelectedItem);
            SetSubTotal();

        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            SetTotal();

        }
    }
}
