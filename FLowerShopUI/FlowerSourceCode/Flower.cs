using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace FlowerUI
{
    public class Flower : IComparable<Flower>
    {
        public string commonName { get; }
        protected string botanical { get; }
        protected int zone { get; }
        protected string light { get;}
        public decimal price { get; set; }
        public bool availabilty { get; set; }
        public int quantity { get; set; }
        public int index; 
        public Flower(string commonName, string botanical, int zone, string light, decimal price)
        {
            this.commonName = commonName;
            this.botanical = botanical;
            this.zone = zone;
            this.light = light;
            this.price = price;
            this.availabilty = true;
            this.quantity = 50;
            this.index = -1;

        }
        public override string ToString()
        {

            return ($"CommonName: {commonName}\n" +
                     $"Botanical: {botanical}\n" +
                     $"Zone: {zone}\n" +
                     $"Light: {light}\n" +
                     $"Price: {price}\n" +
                     $"Available: {availabilty}\n" +
                     $"Quantity: {quantity}\n");
        }

        public int CompareTo( Flower other)
        {
            if (this.commonName == other.commonName &&
              this.botanical == other.botanical &&
              this.zone == other.zone &&
              this.light == other.light &&
              this.price == other.price)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
    }
