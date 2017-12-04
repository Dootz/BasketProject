using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketProject.Classes
{
    class Item
    {
        public String Name { get; private set; }
        public int Price { get; private set; }

        public Item(String name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
