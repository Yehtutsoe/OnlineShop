using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models.Entities
{
    [Table("OrderItem")]
    public class OrderItemEntity:BaseEnittiy
    {
        public int Quantity { get; set; }
        public decimal UnitPrice   { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public OrderEntity Order { get; set; }


        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }


    }
}
