using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;

namespace SalesApp
{
    public class Item
    {
        protected string itemName = "";
        protected decimal itemPrice;
        protected bool isTaxable;

        public string ItemName
        {
            get
            {
                return itemName;
            }
        }
        public decimal ItemPrice
        {
            get
            {
                return itemPrice;
            }
        }
        public bool IsTaxable
        {
            get
            {
                return isTaxable;
            }
        }
    }
    public class ExemptedItem : Item
    {
        public ExemptedItem(string itemName, decimal price)
        {
            this.itemName = itemName;
            this.itemPrice = price;
        }
    }
    public class TaxableItem : Item
    {
        public TaxableItem(string itemName, decimal price)
        {
            this.itemName = itemName;
            this.itemPrice = price;
            
        }
    }
    public class ItemCodes
    {
        string book = "1";
        string musicCD = "2";
        string chocolateBar = "3";
        string importedboxofchocolates1 = "4";
        string importedbottleofperfume1 = "5";
        string importedbottleofperfume2 = "6";
        string bottleofperfume = "7";
        string packetofheadachepills = "8";
        string importedboxofchocolates2 = "9";
    }
    public class ItemPrices
    {
        public decimal bookPrice = 12.49m;
        public decimal musicCDPrice = 14.99m;
        public decimal chocolateBarPrice = 0.85m;
        public decimal importedboxofchocolates1Price = 10.00m;
        public decimal importedbottleofperfume1Price = 27.99m;
        public decimal importedbottleofperfume2Price = 47.50m;
        public decimal bottleofperfumePrice = 18.99m;
        public decimal packetofheadachepillsPrice = 9.75m;
        public decimal importedboxofchocolates2Price = 11.25m;
    }

}
