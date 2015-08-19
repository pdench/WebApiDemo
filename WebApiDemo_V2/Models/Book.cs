using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo_V2.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string  Author { get; set; }
        public decimal Price { get; set; }
    }
}