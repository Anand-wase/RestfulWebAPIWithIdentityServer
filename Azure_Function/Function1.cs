using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using Azure_Function.Data;

namespace Azure_Function
{
    public class Function1
    {

        private readonly ApplicationDbContext _db;
        public Function1(ApplicationDbContext db)
        {
            _db = db;
        }
        [FunctionName("GetAllVillas")]
        public  async Task<IActionResult> Run(
        //[HttpTrigger(AuthorizationLevel.Function, "get", Route = "villas")]
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req ,ILogger log)
        {
            try
            {
                log.LogInformation("Getting Employee list items");
                return new OkObjectResult(await _db.Villas.ToListAsync());

            }
            catch (Exception ex)
            {
                log.LogError($"Error: {ex.Message}");
                return new StatusCodeResult(StatusCodes.Status500InternalServerError); 
            }
        }
    }
}