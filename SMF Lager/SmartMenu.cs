using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMF_Lager
{
    public class SmartMenu
    {
        public void ShowMenu()
        {
            Console.WriteLine("1. Vis vare og information");
            Console.WriteLine("2. Bamsefarfar");
            Console.WriteLine("3. Bamsefarfarfar");

            ItemsRepo r = new ItemsRepo();
            string name;
            int quantity;
            double price;

            string switchCase = Console.ReadLine();
            switch (switchCase)
            {
                case "1":
                    r.GetItemList();
                    break;

                case "2":
                    Console.WriteLine("indtast varenavn");
                    name = Console.ReadLine();
                    r.ShowItem(name);
                    break;

                case "3":
                    Console.WriteLine("Registrer ny vare navn");
                    name = Console.ReadLine();
                    Console.WriteLine("Registrer ny vare antal");
                    quantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Registrer ny vare pris");
                    price = double.Parse(Console.ReadLine());
                    r.RegisterNewItem(name, quantity, price);
                    break;

                default:
                    break;
            }
                



        }
    }
}
