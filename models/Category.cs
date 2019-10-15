using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.models
{
    public class Category
    {
        [System.ComponentModel.DataAnnotations.ScaffoldColumn(false)]
        public int CategoryID { get; set; }
        [System.ComponentModel.DataAnnotations.Required, System.ComponentModel.DataAnnotations.StringLength(100), System.ComponentModel.DataAnnotations.Display(Name = "Name")]
        public string CategoryName { get; set; }
        public virtual ICollection<Toy> Toys { get; set; }
    }
}