using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SalesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ShoppingBasket SBasket = new ShoppingBasket();
                ItemPrices Price = new ItemPrices();
                Console.WriteLine("OUTPUT");
                Console.WriteLine("");
                Console.WriteLine("Output 1:");
                Console.WriteLine("");
                string itemCode = "";
                int ItemQauntity=0;
                Console.WriteLine("============================================================================");
                Console.WriteLine("Item Codes"+":\n"+" book = 1"+"   "+"musicCD = 2"+ "   "+ "chocolateBar = 3\n" + ""+"importedboxofchocolates1 = 4"+"   "+ "importedbottleofperfume1 = 5\n"+""+ "importedbottleofperfume2 = 6"
                +"   "+ "bottleofperfume =7\n"+"   "+ "packetofheadachepills = 8"+ "   "+ "importedboxofchocolates2 =9");
                Console.WriteLine("============================================================================");
                Console.WriteLine("");
                Console.WriteLine("Please Use the provided codes above to Input and Print Item Receipt");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Enter P or p for Item Code && hit the Enter button twice to Print a receipt : Enter X or x on Item Code and hit the enter button twice to exit the program");
                Console.WriteLine("");
                Console.WriteLine("");
                while (true)
                {
                    Console.WriteLine("Enter Item Code and press Enter");
                    Console.Write("Item Code: ");
                    itemCode = Console.ReadLine();
                    Console.WriteLine("Enter Qauntity and press Enter");
                    Console.Write("Qauntity: ");

                    if (!int.TryParse(Console.ReadLine(), out ItemQauntity))
                    { 
                        Console.Write("Qauntity must be of integer type, try again: "); 
                    }
                    else 
                    { 
                        ItemQauntity = ItemQauntity;
                    }
                    
                    if (itemCode == "1")
                    {
                        SBasket.AddNewItemToShoppingList(new ExemptedItem("book", Price.bookPrice), ItemQauntity, false);
                    }
                    if (itemCode == "2")
                    {
                        SBasket.AddNewItemToShoppingList(new TaxableItem("music CD", Price.musicCDPrice), ItemQauntity, false);
                    }
                    if (itemCode == "3")
                    {
                        SBasket.AddNewItemToShoppingList(new TaxableItem("chocolate Bar", Price.chocolateBarPrice), ItemQauntity, false);
                    }
                    if (itemCode == "4")
                    {
                        SBasket.AddNewItemToShoppingList(new TaxableItem("imported box of chocolates", Price.importedboxofchocolates1Price), ItemQauntity, false);
                    }
                    if (itemCode == "5")
                    {
                        SBasket.AddNewItemToShoppingList(new TaxableItem("imported bottle of perfume", Price.importedbottleofperfume2Price), ItemQauntity, false);
                    }
                    if (itemCode == "6")
                    {
                        SBasket.AddNewItemToShoppingList(new TaxableItem("bottle of perfume ", Price.bottleofperfumePrice), ItemQauntity, false);
                    }
                    if (itemCode == "7")
                    {
                        SBasket.AddNewItemToShoppingList(new ExemptedItem("packet of headache pills ", Price.packetofheadachepillsPrice), ItemQauntity, false);
                    }
                    if (itemCode == "8")
                    {
                        SBasket.AddNewItemToShoppingList(new TaxableItem("imported bottle of perfume ", Price.importedbottleofperfume1Price), ItemQauntity, true);
                    }
                    if (itemCode == "9")
                    {
                        SBasket.AddNewItemToShoppingList(new ExemptedItem("imported box of chocolates ", Price.importedboxofchocolates2Price), ItemQauntity, true);
                    }
                    if (itemCode == "P" || itemCode == "p")
                    {
                    //printing receipt
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("----Items Receipt----");
                    Console.WriteLine("");
                    SBasket.PrintReceipt();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    }
                    if (itemCode == "X" || itemCode == "x")
                    {
                        System.Environment.Exit(0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    
}
