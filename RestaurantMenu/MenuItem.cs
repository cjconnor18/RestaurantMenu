using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        private DateTime dateAdded;

        public MenuItem(double price, string description, string category)
        {
            Price = price;
            Description = description;
            Category = category;
        }

        public DateTime DateAdded
        {
            get { return dateAdded; }
            set { dateAdded = value; }
        }
    }
}
