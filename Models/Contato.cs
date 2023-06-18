using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Azure.Data.Tables;

namespace _2_azure_table.Models
{
    public class Contato : ITableEntity
    {
<<<<<<< HEAD
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
=======
>>>>>>> 87ecdf1 (commit inicial)
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }
}