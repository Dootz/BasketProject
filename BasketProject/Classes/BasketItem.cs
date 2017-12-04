using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketProject.Classes
{
    class BasketItem
    {
        public Item ItemType { get; private set; }
        public int Quantity { get; private set; }

        public BasketItem(Item item, int quantity)
        {
            ItemType = item;
            Quantity = quantity;
        }

        public void setQuantity(int quantity)
        {
            Quantity = quantity;
        }

    }
}
