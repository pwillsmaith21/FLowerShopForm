using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;

namespace FlowerUI
{
    public class Cart : FlowerCatalog
    {
        private decimal total { get; set; }
        public int totalItem { get; set; }
        private decimal tax { get; set; }
        private const decimal taxPercentage = 0.0635M;
        private decimal subtotal { get; set; }
        public List<Flower> ShoppingCart = new List<Flower>();
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
                flower.index = flowerIndex;
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

        public string StoreCartData(String userId, int pin)
        {
            using (var connection = new SqlConnection(Helper.CnnVal("testData")))
            {
                string sql = $" insert into flowershopcart values('{userId}', '{pin}','{subtotal}','{total}','{totalItem}');";
                connection.Execute(sql);
                sql = $"insert into flowerDataBase(CustomerUserID, commonName, price, location) values(@CustomerUserID, @commonName, @price, @location);";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                foreach( Flower flower in ShoppingCart)
                {
                    command.Parameters.Add("@CustomerUserID", SqlDbType.VarChar).Value = userId;
                    command.Parameters.Add("@commonName", SqlDbType.VarChar).Value = flower.commonName;
                    command.Parameters.Add("@price", SqlDbType.Decimal).Value = flower.price;
                    command.Parameters.Add("@location", SqlDbType.Int).Value = flower.index;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
                return "Cart save succesfully";
            }
            return "wasnt save successfully";
        }
        public bool LoadDatafromDataBase(String userId, int pin)
        {
            IEnumerable<dynamic> flowerListFromData = null;
            using (var connection = new SqlConnection(Helper.CnnVal("testData")))
            {
                string sql = $"select * from flowershopcart;";
                IDataReader cartDatareader = connection.ExecuteReader(sql);
                while (cartDatareader.Read()) {
                    subtotal = Decimal.Parse(cartDatareader[2].ToString());
                    total = Decimal.Parse(cartDatareader[3].ToString());
                    totalItem = Int32.Parse(cartDatareader[4].ToString());
                }
                cartDatareader.Dispose();
                sql = $" select * from flowerDataBase where CustomerUserID = '{userId}' ;";
                cartDatareader = connection.ExecuteReader(sql);
                AddFlowerToCheckout(cartDatareader);
                cartDatareader.Close();
                return true;
            }
            return false ;

        }
        public void AddFlowerToCheckout(IDataReader cartDataReader)
        {
          while(cartDataReader.Read())
            {
                int location = Int32.Parse(cartDataReader[3].ToString());
                Flower retrieveFlower = catalog.RetrieveFLower(location);
                retrieveFlower.index = location;
                ShoppingCart.Add(retrieveFlower);
            }
        }

    }
}
