using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderNumber { get; set; } = Guid.NewGuid().ToString();
        public double Amount { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
