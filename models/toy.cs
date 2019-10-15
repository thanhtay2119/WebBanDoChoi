﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webbandochoi.models
{
    public class toy
    {
        [System.ComponentModel.DataAnnotations.ScaffoldColumn(false)]
        public int ToyID { get; set; }
        [System.ComponentModel.DataAnnotations.Required, System.ComponentModel.DataAnnotations.StringLength(100), System.ComponentModel.DataAnnotations.Display(Name = "Name")]
        public string ToyName { get; set; }
        [System.ComponentModel.DataAnnotations.Required, System.ComponentModel.DataAnnotations.StringLength(1000), System.ComponentModel.DataAnnotations.Display(Name = "Toy Description"),
        System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Price")]
        public float? UnitPrice { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}