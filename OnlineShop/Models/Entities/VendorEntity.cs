using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;

namespace OnlineShop.Models.Entities
{
    [Table("Vendor")]
    public class VendorEntity:BaseEnittiy
    {
        public string ShopName { get; set; }
        public string Status { get; set; } // Pending , Active , Suspense
        public decimal CommisionRate { get; set; } = 0.1m;
        public decimal FixedFee { get; set; } = 0;

        public ICollection<ProductEntity> Products { get; set; }
    }
}
