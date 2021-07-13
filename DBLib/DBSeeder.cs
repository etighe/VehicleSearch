using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DBLib.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DBLib
{
    public static class DBSeeder
    {

        public static void Seed(string jsonDataPath, IServiceProvider svcProvider)
        {
            var svcScope = svcProvider.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var context = svcScope.ServiceProvider.GetService<VsContext>();
            if (context != null && !context.Vehicles.Any())
            {
                var jsonSeedData = File.ReadAllText(jsonDataPath);
                var data = JsonSerializer.Deserialize<List<VehicleDescription>>(jsonSeedData);

                if (data != null && data.Count > 0)
                {
                    context.AddRange(data);
                    context.SaveChanges();
                }
            }
        }
    }
}
