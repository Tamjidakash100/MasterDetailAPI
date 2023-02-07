using System.ComponentModel.DataAnnotations;

namespace MasterDetailAPI.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
        public decimal GrandTotal { get; set; }
        public List<OrderDetails> OrderDetails{ get; set; }
    }
}
