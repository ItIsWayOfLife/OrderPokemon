using System;

namespace Core.DTOs
{
    public class OrderDTO
    {
        public DateTime DateTimeOrder { get; set; }
        public string UserName { get; set; }
        public int OrderQuantity { get; set; }
    }
}
