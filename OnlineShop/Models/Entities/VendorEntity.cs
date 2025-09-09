using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;

namespace OnlineShop.Models.Entities
{
    [Table("Vendor")]
    public class VendorEntity:BaseEnittiy
    {
        [Required,MaxLength(50)]
        public string ShopName { get; set; } = string.Empty;
        [Required,MaxLength(150)]
        public string Description { get; set; } =string.Empty;


        public ICollection<ProductEntity> Products { get; set; }
    }
}
