using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerUI
{
    public partial class InitialScreen : Form
    {
        private FlowerCatalog catalog;
        private Cart checkoutCart;
        public InitialScreen()
        {
            InitializeComponent();
            catalog = new FlowerCatalog();
            checkoutCart = new Cart(catalog);
        }

        private void loadCartButton_Click(object sender, EventArgs e)
        {
            if (userIdTextBox.Text != null && pinTextBox.Text != null)
            {
                try
                {
                    string userId = userIdTextBox.Text;
                    int pin = Int32.Parse(pinTextBox.Text);
                    MessageBox.Show(checkoutCart.LoadDatafromDataBase(userId, pin).ToString());
                }
                catch (System.FormatException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void newCartButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
