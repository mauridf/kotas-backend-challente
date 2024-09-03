using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kotas_backend_challenge.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MestresPokemon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Idade = table.Column<int>(type: "INTEGER", nullable: false),
                    Cpf = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MestresPokemon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonsCapturados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    DataCaptura = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MestrePokemonId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonsCapturados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonsCapturados_MestresPokemon_MestrePokemonId",
                        column: x => x.MestrePokemonId,
                        principalTable: "MestresPokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonsCapturados_MestrePokemonId",
                table: "PokemonsCapturados",
                column: "MestrePokemonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonsCapturados");

            migrationBuilder.DropTable(
                name: "MestresPokemon");
        }
    }
}
