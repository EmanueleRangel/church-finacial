# Sistema Financeiro para Igreja - Backend

Este repositório contém o backend do sistema financeiro desenvolvido para gerenciar as finanças de uma igreja. O backend foi implementado em C# utilizando [ASP.NET Core](https://learn.microsoft.com/aspnet/core).

## Funcionalidades

- **Autenticação de Usuários**
  - Registro, login e recuperação de senha.
  - Autenticação com JWT.

- **Gestão Financeira**
  - CRUD de transações financeiras (entradas e saídas).
  - Gestão de categorias financeiras.

- **Relatórios**
  - Geração de relatórios financeiros mensais e anuais.
  - Exportação de relatórios em PDF e Excel.

- **Gerenciamento de Usuários**
  - Controle de permissões por perfil (administrador, tesoureiro, membros).

## Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework**: ASP.NET Core  
- **Banco de Dados**: SQL Server
- **Autenticação**: JWT
- **Outras Bibliotecas**: 
  - `Entity Framework Core` para ORM
  - `AutoMapper` para mapeamento de objetos
  - `Serilog` para logging

## Requisitos do Sistema

- .NET SDK 6.0 ou superior
- Banco de dados (SQL Server recomendado)
- Visual Studio ou Visual Studio Code

## Configuração do Ambiente

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/nome-do-repositorio.git
   cd nome-do-repositorio
   ```

2. Configure as variáveis de ambiente no arquivo `appsettings.json` ou `appsettings.Development.json`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=nome_do_banco;User Id=usuario;Password=senha;"
     },
     "Jwt": {
       "Key": "seu_segredo_aqui",
       "Issuer": "sua_emissora_aqui",
       "Audience": "sua_audiencia_aqui"
     }
   }
   ```

3. Configure o banco de dados:
   ```bash
   dotnet ef database update
   ```

4. Inicie o servidor local:
   ```bash
   dotnet run
   ```

## Endpoints Principais

- **Autenticação**
  - POST `/api/auth/login`
  - POST `/api/auth/register`

- **Transações**
  - GET `/api/transactions`
  - POST `/api/transactions`
  - PUT `/api/transactions/{id}`
  - DELETE `/api/transactions/{id}`

- **Relatórios**
  - GET `/api/reports/monthly`
  - GET `/api/reports/annual`

## Testes

Execute os testes automatizados com:
```bash
   dotnet test
```

## Deploy

1. Crie a imagem Docker:
   ```dockerfile
   FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
   WORKDIR /app
   EXPOSE 80

   FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
   WORKDIR /src
   COPY . .
   RUN dotnet restore
   RUN dotnet publish -c Release -o /app/publish

   FROM base AS final
   WORKDIR /app
   COPY --from=build /app/publish .
   ENTRYPOINT ["dotnet", "NomeDoProjeto.dll"]
   ```

2. Configure o pipeline CI/CD com GitHub Actions ou outra ferramenta.

3. Execute o deploy em uma plataforma como Azure, AWS ou Docker Swarm.

## Contribuição

Contribuições são bem-vindas! Para começar:

1. Faça um fork do projeto.
2. Crie um branch para sua feature/bugfix:
   ```bash
   git checkout -b minha-feature
   ```
3. Envie seu código com um pull request.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
