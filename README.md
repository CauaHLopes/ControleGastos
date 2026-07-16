# Controle de Gastos

Projeto desenvolvido utilizando ASP.NET Core Web API, Entity Framework Core e SQLite.

## Tecnologias

- .NET 8
- ASP.NET Core
- Entity Framework Core
- SQLite
- Swagger

## Funcionalidades Implementadas

- Cadastro de pessoas
- Listagem de pessoas
- Exclusão de pessoas
- Persistência de dados utilizando SQLite
- Relacionamento entre Pessoa e Transação
- Migrations do banco de dados

## Como Executar

Restaurar dependências:

```bash
dotnet restore
```

Aplicar migrations:

```bash
dotnet ef database update
```

Executar a aplicação:

```bash
dotnet run
```

Acessar o Swagger:

```text
http://localhost:5150/swagger
```

## Status do Projeto

Devido ao tempo disponível para realização do desafio, priorizei a construção da estrutura principal da aplicação, incluindo modelagem das entidades, configuração do banco de dados, persistência de dados e implementação dos principais endpoints da API.

Algumas funcionalidades previstas permaneceram pendentes, como parte dos endpoints relacionados às transações, consulta consolidada de totais e desenvolvimento da interface em React + TypeScript.

## Contexto

Sou estudante universitário e este projeto foi desenvolvido como parte do meu processo de aprendizado em ASP.NET Core e Entity Framework Core.

Durante o desenvolvimento procurei compreender os conceitos utilizados, organizar o código e documentar os principais componentes da aplicação.

## Autor

Cauã Henrique Lopes