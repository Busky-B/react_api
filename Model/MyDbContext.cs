using Microsoft.EntityFrameworkCore;
using react_api.Model;


namespace react_api.Model
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> opt) : base(opt)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }

    }
}