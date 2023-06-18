# API de armazenamento de contatos na Azure :computer:
## Esta documentação descreve os endpoints e parâmetros da API fornecida. :fire:

## String de conexão :signal_strength:
Nos arquivos da API, eu me conectei a uma conta de armazenamento da Azure

## Endpoints :link:
### :arrow_right: Criar Contato :new:
Endpoint para criar um novo contato.

### :arrow_right: Método: POST :mailbox:
### :arrow_right: Rota: /Contato
### :arrow_right:  Parâmetros: Nenhum :no_entry_sign:
## Exemplo de corpo da solicitação:

#### json :page_facing_up:

{<br>
  "nome": "string",<br>
  "telefone": "string",<br>
  "email": "string",<br>
  "partitionKey": "string",<br>
  "rowKey": "string",<br>
  "timestamp": "2023-06-18T17:19:56.009Z",<br>
  "eTag": {}<br>
}

----------------------------------------------------

###  :arrow_right: Atualizar Contato :arrows_counterclockwise:
Endpoint para atualizar um contato existente.

#### :arrow_right:  Método: PUT :pencil:
#### :arrow_right:  Rota: /Contato/{id}
###  :arrow_right: Parâmetros :wrench: :
####  :arrow_right: id (string, path): ID do contato a ser atualizado
### Exemplo de corpo da solicitação:

#### json :page_facing_up:

{<br>
  "nome": "string",<br>
  "telefone": "string",<br>
  "email": "string",<br>
  "partitionKey": "string",<br>
  "rowKey": "string",<br>
  "timestamp": "2023-06-18T17:19:56.011Z",<br>
  "eTag": {}<br>
}<br>

----------------------------------------------------

### :arrow_right: Excluir Contato :wastebasket:
#### Endpoint para excluir um contato existente.
#### :arrow_right:  Método: DELETE :wastebasket:
#### :arrow_right:  Rota: /Contato/{id}
### :arrow_right:  Parâmetros :wrench: :
####  :arrow_right: id (string, path): ID do contato a ser excluído
<br>

----------------------------------------------------



###  :arrow_right: Listar Todos os Contatos :clipboard:
#### Endpoint para obter uma lista de todos os contatos.

#### Método: GET :mag:
#### Rota: /Contato/ListarTodosOsContatos
### Parâmetros :wrench: : Nenhum :no_entry_sign:
<br>

----------------------------------------------------


### Obter Contato por Nome :mag_right:
#### Endpoint para obter um contato pelo nome.

### Método: GET :mag:
#### Rota: /Contato/ObterPorNome/{nome}
### Parâmetros :wrench: :
#### nome (string, path): Nome do contato a ser obtido
<br>

----------------------------------------------------

### Obter Contato por Email :mag_right:
#### Endpoint para obter um contato pelo email.

### Método: GET :mag:
#### Rota: /Contato/ObterPorEmail/{email}
### Parâmetros :wrench: :
#### email (string, path): Email do contato a ser obtido
<br>

----------------------------------------------------

### Obter Contato por Telefone :mag_right:
#### Endpoint para obter um contato pelo telefone.

### Método: GET :mag:
#### Rota: /Contato/ObterPorTelefone/{telefone}
### Parâmetros :wrench: :
#### telefone (string, path): Telefone do contato a ser obtido
<br>

----------------------------------------------------

## Schemas :page_facing_up:

#### {
####  "nome": "string",
####  "telefone": "string",
####  "email": "string",
####  "partitionKey": "string",
####  "rowKey": "string",
####  "timestamp": "string (format: date-time)",
####  "eTag": {}
#### }


## DOCUMENTAÇÃO :book:

### Para ver a documentação dessa API no Swagger:

### :arrow_right: Faça o clone do repositório na sua máquina.
### :arrow_right: Abra o terminal no diretório aonde foi clonado o repositório

### :arrow_right: Digite o seguinte comando(sem as aspas): :arrow_down:

### "dotnet watch run"