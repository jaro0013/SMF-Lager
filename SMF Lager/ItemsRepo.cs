using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMF_Lager
{
    public class ItemsRepo
    {
        private List<Item> items = new List<Item>();
        
            public void SetUpItems()
            {
            items = new List<Item>
                    {
                        new Item("hvid", 1, 2.5),
                        new Item("sort", 3, 5.0),
                        
                    };
            }
            public string ShowItem(string name)
            {
            SetUpItems();
                foreach(Item item in items)
                {
                    if (item.Name == name)
                    {
                        Console.WriteLine(item);
                    }
                }

            return "fejl";
            
            }
            public void GetItemList()
            {
                SetUpItems();
            foreach (Item obj in items)
            {
                Console.WriteLine(obj);
            }
            }
            public void RegisterNewItem(string name, int quantity, double price)
            {
            Item vare = new Item(name, quantity, price);
            AddItem(vare);
            }
            public void AddItem(Item item)
            {
            items.Add(item);
            }
            public void UpdateQuantity(string name, int quantity)
            {
                foreach(Item i in items)
                {
                    if(i.Name == name)
                    {
                    i.Quantity = quantity;
                    }
                }
            }
            public void UpdatePrice(string name, double price)
            {
                foreach(Item i in items)
                {
                    if(i.Name == name)
                    {
                    i.Price = price;
                    }
                }
            }
        public Item GetItem(string name)
        {
            foreach (Item i in items)
            {
                if(i.Name == name)
                {
                    return i;
                }
            }
            return null;
        }
            public void Save()
            {
                using (var StreamWriter = new StreamWriter("save.txt"))
                {
                    foreach(Item item in items)
                    {
                        StreamWriter.WriteLine("Maling;"+ item.Name + ";Quantity;" + item.Quantity + ";Price;" + item.Price);
                    }
                
                }

            }
            public void Load()
            {
                StreamReader load = new StreamReader("save.txt");
                while (load.EndOfStream == false)
                {
                string line = load.ReadLine();
                String[] Load = line.Split(';');
                Item item = new Item(Load[1], int.Parse(Load[3]), double.Parse(Load[5]));
                }

            load.Close();   
            }
    }
}
