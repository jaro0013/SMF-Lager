using System;
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
            return name;
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

            }
            public void AddItem(Item item)
            {

            }
            public void UpdateQuantity(string name, int quantity)
            {

            }
            public void UpdatePrice(string name, double price)
            {

            }
            public void Save()
            {

            }
            public void Load()
            {

            }
    }
}
