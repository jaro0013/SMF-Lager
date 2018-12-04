using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMF_Lager
{
    class Item
    {

        private string name;
        private int quantity;
        private double price;
        public string Name
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
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
            string stringCollector = name + " " + quantity + " " + price;
            return stringCollector;
        }
    }
}
