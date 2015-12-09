using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sushi.Models.ViewModels
{
    public class MenuItemViewModel
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Selected { get; set; }
    }
}