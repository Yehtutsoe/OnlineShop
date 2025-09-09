using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models.Entities
{
    [Table("Cart")]
    public class CartEntity:BaseEnittiy
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        public UserEntity User { get; set; }
        public ICollection<CartItemEntity> Carts { get; set; }
    }
}
