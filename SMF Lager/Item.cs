using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMF_Lager
{
     public class Item
    {

        private string name;
        private int quantity;
        private double price;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Item(string name, int quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public Item(string name, int quantity)
            : this(name, quantity, 0.0)
        {

        }
        
        public Item(string name)
            : this(name, 0, 0.0)
        {

        }

        
        public override string ToString()
        {
            string stringCollector = "Varenavn: " + name + " Antal: " + quantity + " Pris: " + price;
            return stringCollector;
        }
    }
}
