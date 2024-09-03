# Pokémon Backend API

Este projeto é uma API para listar Pokémons, capturar Pokémons e cadastrar mestres Pokémon, utilizando a API pública PokeAPI e armazenando dados em SQLite.

## Tecnologias Utilizadas
- C#
- .NET 8.0
- ASP.NET Core Web API
- SQLite
- Entity Framework Core
- PokeAPI
- RestSharp

## Como Instalar e Usar o Projeto
1. Clone o repositório.
2. Execute `dotnet restore` para instalar as dependências.
3. Configure o banco de dados SQLite rodando as migrations: `dotnet ef database update`.
4. Inicie o servidor com `dotnet run`.
5. Utilize um cliente HTTP como Postman para interagir com os endpoints da API.

## Endpoints Disponíveis
- `GET /pokemons/random`: Retorna 10 Pokémons aleatórios.
- `GET /pokemons/{id}`: Retorna informações de um Pokémon específico.
- `POST /mestrepokemon`: Cadastra um mestre Pokémon.
- `POST /pokemons/capturar`: Registra a captura de um Pokémon.
- `GET /pokemons/capturados`: Lista todos os Pokémons capturados.