using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models.Entities
{
    [Table("Category")]
    public class CategoryEntity:BaseEnittiy
    {
        [Required,MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, MaxLength(75)]
        public string Description { get; set; } = string.Empty;
        public ICollection<ProductEntity> Products { get; set; }
    }
}
