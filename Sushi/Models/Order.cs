using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sushi.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime timeSent { get; set; }
        public virtual ICollection<MenuItem> OrderItems { get; set; }
    }
}