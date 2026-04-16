using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBookStroreSystem.Models
{
    public class PaymentModel
    {
        public int Id { get; set; }
        [ForeignKey("OrderModel")]
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Status { get; set; }
        public string TransactionId { get; set; }
        public DateTime PaidAt { get; set; } = DateTime.Now;
    }
}
