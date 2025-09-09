using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.SymbolStore;

namespace OnlineShop.Models.Entities
{
    [Table("User")]
    public class UserEntity:BaseEnittiy
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role  { get; set; }

        public Guid VendorId { get; set; }
        public VendorEntity Vendor { get; set; }
    }
}
