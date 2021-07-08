using System;
using System.Collections.Generic;
using System.Text;

namespace FLowerShop
{
    public class Cart : FlowerCatalog
    {
        private decimal total { get; set; }
        public int totalItem { get; set; }
        private decimal tax { get; set; }
        private const decimal taxPercentage = 0.0635M;
        private decimal subtotal { get; set; }
        private List<Flower> ShoppingCart = new List<Flower>();
        private FlowerCatalog catalog;
        public Cart(FlowerCatalog catalog)
        {
            this.catalog = catalog;
            this.total = 0;
            this.totalItem = 0;
            this.tax = 0;

        }
        public void AddToSubtotal(decimal price)
        {
            this.subtotal += price;
        }
        public void SubtracFromSubtotal(decimal price)
        {
            this.subtotal -= price;
        }
        private void calculateTotal()
        {
            CalculateTax();
            this.total = this.subtotal + this.tax;
        }
        public decimal GetTotal()
        {
            calculateTotal();
            return total;
        }
        public decimal GetSubtotal()
        {
            return subtotal;
        }
        private void  CalculateTax()
        {
            this.tax =  subtotal * taxPercentage;

        }
        public bool AddNewItemToCart(int flowerIndex)
        {
            Flower flower = catalog.RetrieveFLower(flowerIndex);
            if (verifyItem(flower))
            {
                AddToSubtotal(flower.price);
                ShoppingCart.Add(flower);
                totalItem += 1;
                return true;
            }
            else
            {
                return false;
            }
          
        }
        public bool removeItemFromCart(int flowerIndex)
        {
            Flower flower = catalog.RetrieveFLower(flowerIndex);
            if (verifyItem(flower))
            {
                SubtracFromSubtotal(flower.price);
                ShoppingCart.Remove(flower);
                totalItem -= 1;

                return true;
            }
            else
            {
                return false;
            }
        }
        public bool verifyItem(Flower flower)
        {
            if (catalog.flowerList.Contains(flower))
            {
                return true;
            }
            else {
                return false;
            }
        }
        public void printCart()
        {
            // to test cart
            Console.WriteLine($"Subtotal: {subtotal}\n" +
                $"Tax: {tax}\n" +
                $"Total: {total}\n");
        }



    }
}
