using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _2_azure_table.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly string _connectionString;
        private readonly string _tableName;

        public ContatoController(IConfiguration configuration)
        {
            _connectionString = configuration.GetValue<string>("sAConnectionString");
            _tableName = configuration.GetValue<string>("AzureTableName");
        }

        
    }
}