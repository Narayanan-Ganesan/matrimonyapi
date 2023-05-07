using MatrimonyAPI.Context;
using MatrimonyAPI.Mappers;
using MatrimonyAPI.Repositories;
using MatrimonyAPI.Services;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace MatrimonyAPI.Extensions.ServiceExtensions
{
    public static class InfrastructureServiceExtensions
    {
        public static void AddInfrastructureServices(this IServiceCollection services, IHostEnvironment hostEnvironment, IConfiguration configuration)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserMapper, UserMapper>();
            services.AddDbContext<MatrimonyDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("MatrimonyDb"));
            });
        }
    }
}
