using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public DateTime DateTimeOrder { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
