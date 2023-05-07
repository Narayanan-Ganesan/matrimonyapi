using MatrimonyAPI.Extensions.ServiceExtensions;

namespace MatrimonyAPI.Extensions
{
    public static class ServiceExtension
    {
        internal static void ConfigureServices(this IServiceCollection services, IConfiguration configuration, IHostEnvironment hostEnvironment)
        {
            services.ConfigureCoreServices(configuration, hostEnvironment);
        }

        internal static void ConfigureCoreServices(this IServiceCollection services, IConfiguration configuration, IHostEnvironment hostEnvironment)
        {
            services.AddControllers();
            services.AddOptions();
            services.AddSwaggerServices();
            services.AddRouting(r => r.SuppressCheckForUnhandledSecurityMetadata = true);
            services.AddCorsServices();
            services.AddInfrastructureServices(hostEnvironment, configuration);
        }
    }
}
