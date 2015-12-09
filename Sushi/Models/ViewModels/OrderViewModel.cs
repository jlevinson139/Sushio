using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sushi.Models.ViewModels
{
    public class OrderViewModel
    { 
        public int OrderId { get; set; }
        public DateTime TimeSent { get; set; }
        public virtual ICollection<MenuItemViewModel> OrderItems { get; set; }
    }
}