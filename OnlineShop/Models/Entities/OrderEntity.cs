using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models.Entities
{
    [Table("Order")]
    public class OrderEntity:BaseEnittiy
    {
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } = "Pending";  // Pending ,Paid, Complete


        [ForeignKey("User")]
        public int UserId { get; set; }
        public UserEntity User { get; set; }

        public ICollection<OrderItemEntity> OrderItems { get; set; }


        public PaymentEntity Payment { get; set; }





    }
}
