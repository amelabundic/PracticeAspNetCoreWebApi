using Contracts;
using Entities;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace MyCompany.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureIISIntegration(this IServiceCollection services) =>
         services.Configure<IISOptions>(options =>
         {

         });

        public static void ConfigureLoggerService(this IServiceCollection services) =>
         services.AddScoped<ILoggerManager, LoggerManager>();
    }

 }
