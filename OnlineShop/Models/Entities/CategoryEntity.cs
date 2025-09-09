using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models.Entities
{
    [Table("Category")]
    public class CategoryEntity:BaseEnittiy
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
