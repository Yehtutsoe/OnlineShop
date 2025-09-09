using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models.Entities
{
    [Table("CartItem")]
    public class CartItemEntity:BaseEnittiy
    {
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public CartEntity Cart { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }
        public int Quantity { get; set; }
    }
}
