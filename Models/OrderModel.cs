using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBookStroreSystem.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        [ForeignKey("UserModel")]
        public string UserId { get; set; }
        
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;

        

    }
}
