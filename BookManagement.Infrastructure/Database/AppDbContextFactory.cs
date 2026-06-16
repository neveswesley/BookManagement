using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookManagement.Infrastructure.Database;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

        optionsBuilder.UseSqlServer
            ("Server=.\\SQLEXPRESS;Database=BookManagement;Trusted_Connection=True;TrustServerCertificate=True;");
        
        return new AppDbContext(optionsBuilder.Options);
    }
}