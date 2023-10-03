//using Azure_Function.Data;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace Azure_Function
//{
//    public class ServiceProviderBuilder : IServiceProviderBuilder
//    {
//        public IServiceProvider Build()
//        {
//            IConfigurationRoot config = new ConfigurationBuilder()
//                .SetBasePath(Environment.CurrentDirectory)
//                .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
//                .AddEnvironmentVariables()
//                .Build();
//            var connectionString = config.GetConnectionString("SqlConnectionString");
//            var services = new ServiceCollection();
//            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
//            return services.BuildServiceProvider(true);
//        }
//    }
//}
