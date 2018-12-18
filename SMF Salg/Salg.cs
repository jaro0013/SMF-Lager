using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMF_Lager;

namespace SMF_Salg
{
     public class Salg
     {
        private List<Item> cart = new List<Item>();
        public void ChooseItem(string name, int quantity)
        {
            ItemsRepo ir = new ItemsRepo();
            Item i = ir.GetItem(name);

            if(quantity <= i.Quantity)
            {
                AddToCart(i);
            }
            else
            {
                Console.WriteLine("ikke nok på lager");
            }
        }
        public void AddToCart(Item i)
        {
            cart.Add(i);
        }
    }
}
