using Bookshelf.Infra.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Bookshelf.API.Extensions;

public static class DatabaseConfiguration
{
    public static void ConfigureDatabase(this IServiceCollection services, IHostApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(connectionString));
    }
}