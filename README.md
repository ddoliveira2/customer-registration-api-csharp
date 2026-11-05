# customer-registration-api-csharp

API RESTful desenvolvida em C# para gerenciamento do cadastro de clientes, incluindo validações e operações de manipulação de dados por meio de serviços web.

## Sobre o Projeto

API RESTful desenvolvida em C# para gerenciamento do cadastro de clientes, incluindo validações e operações de manipulação de dados por meio de serviços web.

## Tecnologias Utilizadas

- C#
- .NET Core / ASP.NET Core Web API
- Entity Framework Core
- Swagger / OpenAPI
- SQL Server

## Funcionalidades

- Cadastro de clientes
- Atualização de dados cadastrais
- Consulta de clientes por identificador e listagem
- Exclusão de registros
- Validação dos dados de entrada

## Arquitetura do Projeto

Arquitetura em camadas, organizada em Controller, Service, Repository e Domain/DTOs. Essa separação permite distribuir as responsabilidades entre a entrada das requisições, as regras de negócio e o acesso aos dados.

## Banco de Dados

SQL Server

## Como Executar

1. Clone este repositório.
2. Abra a solução no Visual Studio ou IDE compatível com .NET.
3. Configure a connection string do SQL Server no arquivo de configuração da aplicação.
4. Verifique e aplique as migrations ou scripts de banco de dados existentes no projeto.
5. Restaure os pacotes NuGet, compile e execute a aplicação.
6. Acesse a documentação Swagger, caso esteja habilitada no ambiente.

## Aprendizados

- Criação de APIs RESTful com C# e ASP.NET Core.
- Separação de responsabilidades em camadas.
- Persistência de dados com Entity Framework Core.
- Validação de entradas e documentação de serviços com Swagger.

## Autor

**Daniel**

- GitHub: https://github.com/ddoliveira2
- LinkedIn: https://www.linkedin.com/in/daniel-donizete-7a9a7292/

## Licença

Este projeto está disponibilizado para fins de estudo e demonstração de conhecimentos. Caso deseje definir uma licença de uso, adicione aqui o arquivo e os termos correspondentes.
