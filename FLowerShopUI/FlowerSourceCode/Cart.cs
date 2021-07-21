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

        public string StoreCartData(String userId, int pin)
        {
            using (var connection = new SqlConnection(Helper.CnnVal("testData")))
            {
                string sql = $" insert into flowershopcart values('{userId}', '{pin}','{subtotal}','{total}','{totalItem}','{userId}');";
                connection.Execute(sql);
                sql = $"create table {userId}(id int, flowerName varchar(30), price Decimal(10,5));";
                connection.Execute(sql);
                sql = $"insert into {userId}(id, flowerName, price) values(@id, @flowerName, @price);";
                SqlCommand command = new SqlCommand(sql, connection);
                int count = 1;
                connection.Open();
                foreach( Flower flower in ShoppingCart)
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = count;
                    command.Parameters.Add("@flowerName", SqlDbType.VarChar).Value = flower.commonName;
                    command.Parameters.Add("@price", SqlDbType.Decimal).Value = flower.price;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    count++;
                }
                connection.Close();
                return "Cart save succesfully";
            }
            return "wasnt save successfully";
        }
        public bool LoadDatafromDataBase(String userId, int pin)
        {
            using (var connection = new SqlConnection(Helper.CnnVal("testData")))
            {
                string sql = $"select * from flowershopcart;";
                IDataReader cartDatareader = connection.ExecuteReader(sql);
                string flowerShopDatabaseName = string.Empty;
                while (cartDatareader.Read()) {
                    subtotal = Decimal.Parse(cartDatareader[2].ToString());
                    total = Decimal.Parse(cartDatareader[3].ToString());
                    totalItem = Int32.Parse(cartDatareader[4].ToString());
                    flowerShopDatabaseName = cartDatareader[5].ToString();
                }
                cartDatareader.Close();
                sql = $" select * from {flowerShopDatabaseName};";
                var flowerListFromData = connection.Query(sql).AsList();
                foreach( var f in flowerListFromData)
                {
                    Console.WriteLine(f);
                }
                return true;
            }
            return false;

        }
        private void AddDataToCart()
        {

        }

    }
}
