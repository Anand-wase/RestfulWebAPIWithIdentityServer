//using Azure_Function.Data;
//using Microsoft.Azure.Functions.Extensions.DependencyInjection;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



//namespace Azure_Function
//{
//    public class Startup : FunctionsStartup
//    {
//        public override void Configure(IFunctionsHostBuilder builder)
//        {
//            // Configure Entity Framework Core with SQL Server
//            builder.Services.AddDbContext<ApplicationDbContext>(options =>
//            {
//                options.UseSqlServer(Environment.GetEnvironmentVariable("DefaultSQLConnection"));
//            });
//        }



//    }
//}

//using MessagesToSqlDbFuncApp;
//using Microsoft.Azure.WebJobs.Hosting;
//using Microsoft.Azure.WebJobs;
//using Microsoft.Azure.Functions.Extensions.DependencyInjection;
//using System;

//[assembly: WebJobsStartup(typeof(Startup))]
//namespace MessagesToSqlDbFuncApp
//{
//    internal class Startup : IWebJobsStartup
//    {
//        public void Configure(IWebJobsBuilder builder) =>
//        builder.AddDependencyInjection<ServiceProviderBuilder>();
//    }
//}

using Azure_Function.Data;
using Azure_Function.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(API_EFCore_AzureFunctions.Startup))]

namespace API_EFCore_AzureFunctions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            string connectionString = "Server = AB-LPT-VJY-123\\SQLEXPRESS; Database = Magic_VillaAPI; TrustServerCertificate = True; Trusted_Connection = True; MultipleActiveResultSets = true";
            builder.Services.AddDbContext<ApplicationDbContext>(
                options => SqlServerDbContextOptionsExtensions.UseSqlServer(options, connectionString));
        }
    }
} 



