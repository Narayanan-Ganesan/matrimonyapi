using Microsoft.AspNetCore.Cors.Infrastructure;

namespace MatrimonyAPI.Extensions.ServiceExtensions
{
    public static class CorsServiceExtensions
    {
        internal static void AddCorsServices(this IServiceCollection services)
        {
            var corsBuilder = new CorsPolicyBuilder();
            corsBuilder.AllowAnyHeader();
            corsBuilder.AllowAnyMethod();
            corsBuilder.AllowAnyOrigin();
            services.AddCors(options => options.AddPolicy("SiteCorePolicy", corsBuilder.Build()));
        }
    }
}
