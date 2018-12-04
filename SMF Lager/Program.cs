using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMF_Lager
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemsRepo m = new ItemsRepo();
            m.GetItemList();
        }
    }
}
