using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace SalesApp
{
    public class ShoppingBasket
    {
       public List<ItemList> ShoppingList = new List<ItemList>();

       public class ItemList
        {
            private Item item;
            private int quantity;
            private bool isImported;

            public Item ShopItem 
            { 
                get 
                { 
                    return item; 
                } 
            }
            public int Quantity 
            {
                get 
                { 
                    return quantity;
                } 
            }
            public bool IsImported 
            { 
                get 
                { 
                    return isImported; 
                } 
            }

            public ItemList(Item item, int quantity, bool isImportedItem)
            {
                this.item = item;
                this.quantity = quantity;
                this.isImported = isImportedItem;
            }
        }

        public void AddNewItemToShoppingList(Item item, int quantity, bool isImportedItem)
        {
            ShoppingList.Add(new ItemList(item, quantity, isImportedItem));
        }
        //compute normal sales tax 10% rounding n%
        public decimal computeSalesTax(ItemList Item)
        {
            decimal salestax = 0;

             if (Item.ShopItem is TaxableItem)
             {
              salestax = (Item.Quantity * Item.ShopItem.ItemPrice) * 0.1m;
            }
            return Math.Round(salestax, 2);
        }
        //compute normal Import duty
        public decimal computeImportTax(ItemList Item)
        {
            decimal importduty = 0;
            if (Item.IsImported == true)
            {
                importduty = (Item.Quantity * Item.ShopItem.ItemPrice) * .05m;
            }
           return Math.Round(importduty, 1);
        }

        //This method loops through the shopping list computes taxes and prints the output to a console
        //sales Tax and Import duty are computed seperately for each item on the shopping list
        public void PrintReceipt()
        {
            decimal SalesTax = 0;
            decimal Importduty = 0;
            decimal totalTax = 0;
            decimal netTotal = 0;
            try
            {
                foreach (var Item in ShoppingList)
                {
                    SalesTax = computeSalesTax(Item)*Item.Quantity;
                    Importduty = computeImportTax(Item)*Item.Quantity;
                    decimal tax = SalesTax + Importduty;
                    Console.WriteLine(Item.Quantity + " " + Item.ShopItem.ItemName + ":" + (Item.ShopItem.ItemPrice * Item.Quantity + tax));
                    totalTax += tax;
                    netTotal += Item.ShopItem.ItemPrice * Item.Quantity + tax;
                }
                Console.WriteLine("Sales Taxes : " + totalTax);
                Console.WriteLine("Total : " + netTotal);
                //ShoppingList.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

   
}
