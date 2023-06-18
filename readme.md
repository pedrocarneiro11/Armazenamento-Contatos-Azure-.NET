# API de armazenamento de contatos na Azure
## Esta documentação descreve os endpoints e parâmetros da API fornecida.

## String de conexão
Nos arquivos da API, eu me conectei a uma conta de armazenamento da Azure

## Autenticação
A API utiliza autenticação do tipo Bearer Token. Certifique-se de incluir o token de autenticação no cabeçalho Authorization para todas as solicitações.

Endpoints
Criar Contato
Endpoint para criar um novo contato.

Método: POST
Rota: /Contato
Parâmetros: Nenhum
Exemplo de corpo da solicitação:

json
Copy code
{
  "nome": "string",
  "telefone": "string",
  "email": "string",
  "partitionKey": "string",
  "rowKey": "string",
  "timestamp": "2023-06-18T17:19:56.009Z",
  "eTag": {}
}
Atualizar Contato
Endpoint para atualizar um contato existente.

Método: PUT
Rota: /Contato/{id}
Parâmetros:
id (string, path): ID do contato a ser atualizado
Exemplo de corpo da solicitação:

json
Copy code
{
  "nome": "string",
  "telefone": "string",
  "email": "string",
  "partitionKey": "string",
  "rowKey": "string",
  "timestamp": "2023-06-18T17:19:56.011Z",
  "eTag": {}
}
Excluir Contato
Endpoint para excluir um contato existente.

Método: DELETE
Rota: /Contato/{id}
Parâmetros:
id (string, path): ID do contato a ser excluído
Listar Todos os Contatos
Endpoint para obter uma lista de todos os contatos.

Método: GET
Rota: /Contato/ListarTodosOsContatos
Parâmetros: Nenhum
Obter Contato por Nome
Endpoint para obter um contato pelo nome.

Método: GET
Rota: /Contato/ObterPorNome/{nome}
Parâmetros:
nome (string, path): Nome do contato a ser obtido
Obter Contato por Email
Endpoint para obter um contato pelo email.

Método: GET
Rota: /Contato/ObterPorEmail/{email}
Parâmetros:
email (string, path): Email do contato a ser obtido
Obter Contato por Telefone
Endpoint para obter um contato pelo telefone.

Método: GET
Rota: /Contato/ObterPorTelefone/{telefone}
Parâmetros:
telefone (string, path): Telefone do contato a ser obtido
Schemas
Contato
json
Copy code
{
  "nome": "string",
  "telefone": "string",
  "email": "string",
  "partitionKey": "string",
  "rowKey": "string",
  "timestamp": "string (format: date-time)",
  "eTag": {}
}
ETag
json
Copy code
{}
Lembre-se de substituir https://api.example.com pela URL correta da sua API.