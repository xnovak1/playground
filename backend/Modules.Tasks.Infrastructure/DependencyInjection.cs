using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Modules.Tasks.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.Tasks.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("postgresql");

            services.AddDbContext<TasksDbContext>(options =>
                options.UseNpgsql(connectionString));
        }
    }
}
