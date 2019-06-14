using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SisRestaurante.Infra.Data.Context;

namespace SisRestaurante.API.Extensions
{
    public static class ServiceExtesion
    {
        public static void ConfigCors(this IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy("Policy",
                buider => buider.AllowCredentials()
                .AllowAnyMethod()
                .AllowAnyOrigin()
                .AllowAnyHeader()));
        }

        public static void ConfigureSqlServer(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionStrings:dbConnection"];
            services.AddDbContext<DataContext>(o => o.UseSqlServer(connectionString));
        }
    }
}
