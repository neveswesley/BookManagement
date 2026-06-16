using BookManagement.Domain.Interfaces;
using BookManagement.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;

namespace BookManagement.Infrastructure.Database;

public static class ServiceExtensions
{
    public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
    {
        AddConnectionString(services, configuration);
        AddRepositories(services);
        
    }

    private static void AddConnectionString(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
    }

    private static void AddRepositories(this IServiceCollection services)
    {
        //services.AddScoped<IAuthorRepository, AuthorRepository>();
        //services.AddScoped<IBookRepository, BookRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
    }
}