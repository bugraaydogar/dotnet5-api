using Microsoft.EntityFrameworkCore;

namespace hello_world_net
{
    public class HelloDBContext : DbContext
    {
        public HelloDBContext(DbContextOptions<HelloDBContext> options)
            : base(options) { }

        public DbSet<HelloWorldNet.Models.Customer> Customers { get; set; }
    }
}