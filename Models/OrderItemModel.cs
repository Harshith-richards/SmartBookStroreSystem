using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBookStroreSystem.Models
{
    public class OrderItemModel
    {
        public int Id { get; set; }
        [ForeignKey("OrderModel")]
        public int OrderId { get; set; }
        [ForeignKey("BookModel")]
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
