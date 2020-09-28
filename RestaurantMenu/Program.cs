using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem item1= new MenuItem(1.00, "Ice Cream", "dessert");
            Menu newMenu = new Menu();
            newMenu.addItem(item1);

            Console.WriteLine(newMenu.StringMenu());

            List<MenuItem> itemsAwaitingAdd = new List<MenuItem>();


            Console.WriteLine("Enter 0 to edit Menu");
            string inputNum = Console.ReadLine();
            while(inputNum != "9")
            {
                string editMenu = "1- Create Item \n2- Add Item to Menu \n3- View Menu\n9-exit";
                Console.WriteLine(editMenu);
                inputNum = Console.ReadLine();

                if(inputNum == "1")
                {
                    Console.WriteLine("You have chosen to Create an item \nPlease enter price: ");
                    double price = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter description:");
                    string description = Console.ReadLine();
                    Console.WriteLine("Please enter number for the following categories \n1- Appetizer \n2-Main Course\n3- Dessert ");
                    string categoryNum = Console.ReadLine();
                    string category = "";
                    if(categoryNum == "1")
                    {
                        category = "appetizer";
                    } else if (categoryNum == "2")
                    {
                        category = "main course";
                    } else if (categoryNum == "3")
                    {
                        category = "dessert";
                    }

                    MenuItem createdItem = new MenuItem(price, description, category);
                    itemsAwaitingAdd.Add(createdItem);
                    
                  

                } else if (inputNum == "2")
                {
                    Console.WriteLine("Chose a number to add item"); 
                    for(int i = 0; i < itemsAwaitingAdd.Count; i++)
                    {
                        Console.WriteLine(i + "- " + itemsAwaitingAdd[i].Description);
                    }
                    int itemSelectedNum = int.Parse(Console.ReadLine());
                    newMenu.addItem(itemsAwaitingAdd[itemSelectedNum]);
                    itemsAwaitingAdd.Remove(itemsAwaitingAdd[itemSelectedNum]);

                } else if (inputNum == "3")
                {
                    Console.WriteLine(newMenu.StringMenu());
                }








            }
        }
    }
}
