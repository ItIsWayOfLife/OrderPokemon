using System;

namespace Web.Models
{
    public class OrderViewModel
    {
        public DateTime DateTimeOrder { get; set; }
        public string UserName { get; set; }
        public int OrderQuantity { get; set; }
    }
}
