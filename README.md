# FilmesAppCrud


Realizado a instalação das aplicações/frameworks abaixo:

- Visual Studio Code;
- .NET Core SDK 2.x;
- Instalar sdk (ver compatibilização de versões);
- Extensão C# no VS Code (verificar ativação, desativação, reload);
- Cadastrar uma Conta no Azure;
- Baixar o Git;


Primeira aplicação Web .NET Core 2.x Razor Pages. A aplicação constitui em um CRUD (Create, Read, Update e Delete) de um site de Filmes: 


Etapas:

Parte 1: Criando Razor Pages usando o dotnet CLI e VS Code;

Parte 2: Adicionando um modelo para a aplicaçao ASP.NET Core Razor Pages;

Parte 3: Atualizando e gerando páginas;

Parte 4: Adicionando busca para a aplicação Razor Pages;

Parte 5: Build & Deploy da Aplicação no Azure App Service;

Passos:

- Criando aplicação .NET Core;

- Instalando Importantes Plugins do VS Code;

- Adicionando Modelo & Criando a BD com EF Core;

- Data Annotations na Classe Modelo;

- Melhorias de Front-End no Projeto (.cshtml;

- Adicionando Busca no Index.html;

- Build & Deploy da Aplicação para o Azure e Git;

Comandos para utilizar o projeto de maneira local, executando os comandos abaixo:

- dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design;
- dotnet add package Microsoft.EntityFrameworkCore.Sqlite;
- dotnet restore;
- dotnet ef migrations add InitialCreate;
- dotnet ef database update;

Foi criado uma base de dados para que possa ser testada na hora de executar a aplicação ao dar o comando: "dotnet run" na raiz do projeto:


