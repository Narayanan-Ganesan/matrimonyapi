using Microsoft.OpenApi.Models;
using System.Reflection;

namespace MatrimonyAPI.Extensions.ServiceExtensions
{
    public static class SwaggerServiceExtensions
    {
        internal static void AddSwaggerServices(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Matrimony API", Version = "v1" });
                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //options.IncludeXmlComments(xmlPath);
            });
        }
    }
}
