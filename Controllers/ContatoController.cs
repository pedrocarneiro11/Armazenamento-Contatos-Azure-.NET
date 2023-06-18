using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using _2_azure_table.Models;
using Azure.Data.Tables;
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

        private TableClient GetTableClient()
        {
            var serviceClient = new TableServiceClient(_connectionString);
            var tableClient = serviceClient.GetTableClient(_tableName);

            tableClient.CreateIfNotExists();
            return tableClient;
        }

        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            var tableClient = GetTableClient();

            contato.RowKey = Guid.NewGuid().ToString();
            contato.PartitionKey = contato.RowKey;

            tableClient.UpsertEntity(contato);
            
            return Ok(contato);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(string id, Contato contato)
        {
            var tableClient = GetTableClient();
            var contatoTable = tableClient.GetEntity<Contato>(id, id).Value;

            contatoTable.Nome = contato.Nome;
            contatoTable.Email = contato.Email;
            contatoTable.Telefone = contato.Telefone;

            tableClient.UpsertEntity(contatoTable);
            return Ok();
        }

        [HttpGet("ListarTodosOsContatos")]
        public IActionResult ObterTodos()
        {
            var tableClient = GetTableClient();
            var contatos = tableClient.Query<Contato>().ToList();

            return Ok(contatos);
        }

        [HttpGet("ObterPorNome/{nome}")]
        public IActionResult ObterPorNome(string nome)
        {
            var tableClient = GetTableClient();
            var contatos = tableClient.Query<Contato>(x => x.Nome == nome).ToList();
            var count = contatos.Count();

            if (count > 0)
            {
                return Ok(contatos);
            }

            return NotFound();            
        }

        [HttpGet("ObterPorEmail/{email}")]
        public IActionResult ObterPorEmail(string email)
        {
            var tableClient = GetTableClient();
            var contatos = tableClient.Query<Contato>(x => x.Email == email).ToList();
            var count = contatos.Count();

            if (count > 0)
            {
                return Ok(contatos);
            }

            return NotFound();            
        }

        [HttpGet("ObterPorTelefone/{telefone}")]
        public IActionResult ObterPorTelefone(string telefone)
        {
            var tableClient = GetTableClient();
            var contatos = tableClient.Query<Contato>(x => x.Telefone == telefone).ToList();
            var count = contatos.Count();

            if (count > 0)
            {
                return Ok(contatos);
            }

            return NotFound();            
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(string id)
        {
            var tableClient = GetTableClient();
            tableClient.DeleteEntity(id, id); // id = partition key or row key
            return NoContent();
        }
    }
}