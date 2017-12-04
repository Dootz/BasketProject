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
        public void removeAllItemsWithName(Item item)
        {
            ItemList.RemoveAll(x => x.ItemType.Name == item.Name);
        }

        /**
         * Remove x items from basket
         */
        public void removeXItems(Item item, int quantity)
        {
            var searchedItem = ItemList.Find(x => x.ItemType == item);
            int newQuantity;

            if (searchedItem != null) {
                var currentQuantityInBasket = searchedItem.Quantity;

                if (currentQuantityInBasket <= 0)
                    throw new BasketException($"You currently have invalid number of items in your basket {currentQuantityInBasket}. Let me clear this mess for you.");

                // If there's more than 0 items in basket check if it's possible to remove given 'quantity'
                if (currentQuantityInBasket - quantity < 0)
                    newQuantity = 0;
                else
                    newQuantity = currentQuantityInBasket - quantity;

                // Assign new value to basket item
                searchedItem.setQuantity(newQuantity);
            }
        }
    }
}
