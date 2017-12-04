using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketProject.Classes
{
    class Basket
    {
        public List<BasketItem> ItemList { get; private set; }

        /** Add item to basket
         * @param Item - item to add
         */
        public void addItem(Item item, int quantity)
        {
            ItemList.Add(new BasketItem ( item, quantity ));
        }        

        /*
         * Remove all items from basket with given name
         */
        public void removeAllItemsWithName(String name)
        {
            ItemList.RemoveAll(x => x.ItemType.Name == name);
        }
    }
}
