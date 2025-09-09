using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models.Entities
{
    [Table("Payment")]
    public class PaymentEntity:BaseEnittiy
    {
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public OrderEntity Order { get; set; }

        [Required, StringLength(50)]
        public string Method { get; set; } // e.g., Cash, Card, KBZPay

        [Required, Range(0, 999999)]
        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; } = DateTime.Now;
    }
}
