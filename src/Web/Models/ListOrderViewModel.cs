using System.Collections.Generic;

namespace Web.Models
{
    public class ListOrderViewModel
    {
          public IEnumerable<OrderViewModel> Orders { get; set; }
    }
}
