using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class AppDbContext : DbContext
{
   

    private readonly IConfiguration _configuration;

    public DbSet<Task> Tasks { get; set; }

       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}
