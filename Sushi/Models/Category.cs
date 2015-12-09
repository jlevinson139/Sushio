using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sushi.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public String Name { get; set; }
        public virtual ICollection<MenuItem> CategoryMenuItems { get; set; }
    }
}