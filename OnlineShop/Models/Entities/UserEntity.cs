using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.SymbolStore;

namespace OnlineShop.Models.Entities
{
    [Table("User")]
    public class UserEntity:BaseEnittiy
    {
        [Required, StringLength(100)]
        public string FullName { get; set; }

        [Required, StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(100)]
        public string PasswordHash { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        // Relationships
        public ICollection<OrderEntity> Orders { get; set; }
        public CartEntity Cart { get; set; }
    }
}
