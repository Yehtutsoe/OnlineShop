using Microsoft.EntityFrameworkCore;

namespace OnlineShop.Data.DAO
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
    }
}
