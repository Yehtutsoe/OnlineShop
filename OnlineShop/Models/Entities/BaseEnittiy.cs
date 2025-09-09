using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models.Entities
{
    public class BaseEnittiy
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime UpdateAt { get; set; }
    }
}
