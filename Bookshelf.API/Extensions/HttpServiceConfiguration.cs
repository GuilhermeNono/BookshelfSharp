namespace Bookshelf.API.Extensions;

public static class HttpServiceConfiguration
{
    public static void ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(option =>
        {
            option.AddPolicy("CorsPolicy", builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin());
        });
    }
}