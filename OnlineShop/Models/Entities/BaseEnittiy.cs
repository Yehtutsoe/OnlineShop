using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models.Entities
{
    public class BaseEnittiy
    {
        [Key]
        public int Id { get; set; } 
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime UpdateAt { get; set; }
    }
}
