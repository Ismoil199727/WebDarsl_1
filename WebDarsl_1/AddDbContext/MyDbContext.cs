using Microsoft.EntityFrameworkCore;
using WebDarsl_1.Models;

namespace WebDarsl_1.AddDbContext
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Hodim> Hodims{ get; set; }
    }
}
