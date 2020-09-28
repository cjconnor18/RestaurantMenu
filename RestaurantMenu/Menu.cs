using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        public List<MenuItem> ItemsOnMenu { get; set; }
        public DateTime LastUpdate { get; set; }

        public Menu ()
        {
            ItemsOnMenu = new List<MenuItem>();
            LastUpdate = DateTime.Now;
        }

        public void addItem (MenuItem newItem)
        {
            newItem.DateAdded = DateTime.Today;
            ItemsOnMenu.Add(newItem);
            LastUpdate = DateTime.Now;
        }

        public string StringMenuItem (MenuItem item)
        {
            return item.Price + " "+ item.Description + " " + item.Category;
        }

        public String StringMenu()
        {
            StringBuilder appetizer = new StringBuilder("Appetizer");
            StringBuilder mainCourse = new StringBuilder("Main Course");
            StringBuilder dessert = new StringBuilder("Dessert");
            foreach (MenuItem item in ItemsOnMenu)
            {
                if (item.Category == "appetizer")
                {
                    appetizer.Append("\n" + StringMenuItem(item));
                } else if (item.Category == "main course")
                {
                    mainCourse.Append("\n" + StringMenuItem(item));
                } else if (item.Category == "dessert")
                {
                    dessert.Append("\n" + StringMenuItem(item));
                }
            }
            return appetizer.ToString() + "\n\n" + mainCourse.ToString() + "\n\n" + dessert.ToString() + "\n\n" + "Last Update: " + LastUpdate.ToString();
        }
    }
}
