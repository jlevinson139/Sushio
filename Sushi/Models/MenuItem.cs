using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sushi.Models
{
    public class MenuItem
    {
        [Key]
        public int ItemId { get; set; }
        public String Description { get; set; }
        public String Name { get; set; }
        public float Cost { get; set; }
        public String Picture { get; set; }
        // Picture???????
        public String Category { get; set; }
    }
}