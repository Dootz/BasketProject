using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketProject.Classes
{
    class Basket
    {
        public List<Item> ItemList { get; private set; }

        /** Add item to basket
         * @param Item - item to add
         */
        public void addItem(Item item)
        {
            ItemList.Add(item);
        }

        /*
         * Remove all items from list
         */
        public void removeAllItems()
        {
            ItemList.RemoveAll(IsItem);
        }

        /**
         * Check if object is Item
         * @param object to check
         */
        public static bool IsItem(object obj)
        {
            if (obj is Item)
                return true;

            return false;
        }
    }
}
