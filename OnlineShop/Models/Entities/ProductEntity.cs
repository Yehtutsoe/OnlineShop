using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models.Entities
{
    [Table("Product")]
    public class ProductEntity:BaseEnittiy
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        // VendorId nullable (Single Vendor → Multi-Vendor ready)
        [ForeignKey("Vendor")]
        public int? VendorId { get; set; }
        public VendorEntity Vendor { get; set; }

        public ICollection<OrderItemEntity> OrderItems { get; set; }
        public ICollection<CartItemEntity> CartItems { get; set; }
    }
}
