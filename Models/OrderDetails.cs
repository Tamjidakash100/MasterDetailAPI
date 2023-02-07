using System.ComponentModel.DataAnnotations;

namespace MasterDetailAPI.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
        public Order order { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
