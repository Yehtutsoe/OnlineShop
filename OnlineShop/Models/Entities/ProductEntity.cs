using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models.Entities
{
    [Table("Product")]
    public class ProductEntity:BaseEnittiy
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }
        
        public Guid CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        // VendorId nullable (Single Vendor → Multi-Vendor ready)
        public Guid? VendorId { get; set; }
        public VendorEntity Vendor { get; set; }
    }
}
