using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using System.Globalization;

namespace FLowerShop
{
    public class FlowerCatalog
    {
        public  List<Flower> flowerList = new List<Flower>();
       
        public void loadDataFromXml()
        {
            XElement xmlFile = XElement.Load(@"http://www-db.deis.unibo.it/courses/TW/DOCS/w3schools/xml/plant_catalog.xml");
            var listOfFlower = from node in xmlFile.Descendants("PLANT")
                               select node into flower
                               select new Flower(flower.Element("COMMON").Value, flower.Element("BOTANICAL").Value, ConvertToInt(flower.Element("ZONE").Value), flower.Element("LIGHT").Value, ConvertToDecimal(flower.Element("PRICE").Value));
            flowerList = listOfFlower.ToList();

        }
       
        public int ConvertToInt(String zone)
        {
            try
            {
                int parseInt = Int32.Parse(zone);
                return parseInt;
            }
            catch(System.FormatException e)
            {
                return 0;
            }
        
        }
        public List<string> DisplayListOfFLower()
        {
            List<string> list = new List<string>();
            for ( int i = 0 ,  y =1; i < flowerList.Count(); i++, y++)
            {
                list.Add($"{y}: {flowerList.ElementAt(i).commonName} Price: ${flowerList.ElementAt(i).price}\n");
            }
            return list; 
        }
        public Flower RetrieveFLower(int location)
            
        {
            location -= 1;
            if( location >= 0 && location< flowerList.Count)
            {
                return (flowerList.ElementAt(location));

            }
            else
            {
                return new Flower("null", "null", 0, "null",0.0M);
            }
            
        }

        private decimal ConvertToDecimal(string price)
        {
            String trimPrice = price.Trim('$');

            return decimal.Parse(trimPrice, NumberStyles.Currency);
        }
    }
}
