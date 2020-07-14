using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOrderApp.Models
{
    public enum MenuItemType
    {
        Foods,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
