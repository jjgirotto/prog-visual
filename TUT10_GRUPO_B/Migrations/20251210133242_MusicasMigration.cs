using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TUT10_GRUPO_B.Migrations
{
    /// <inheritdoc />
    public partial class MusicasMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "Musica_BId",
                keyValue: new Guid("042e632a-1ebb-4d39-b2b8-0d2b447d38da"));

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "Musica_BId",
                keyValue: new Guid("ad63b0c4-c80e-427a-8f53-117825defa8a"));

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "Musica_BId",
                keyValue: new Guid("c2ce0c0d-1c6d-4ce5-83f9-6672d7eabeff"));

            migrationBuilder.InsertData(
                table: "Fotos",
                columns: new[] { "Musica_BId", "Autor_B", "Duracao_B", "Ficheiro_B", "Titulo_B" },
                values: new object[,]
                {
                    { new Guid("4f83abdb-1bc4-42b6-afc8-bf75c7ad511e"), "Rubel", 422, "/musicas/quadro verde.mp3", "Quadro Verde" },
                    { new Guid("61d2efbe-1003-482b-a561-ed635a892f1e"), "5 a Seco", 199, "/musicas/pensando bem.mp3", "Pensando Bem" },
                    { new Guid("d7606613-d319-40e7-9086-10e1201939d5"), "Anavitória", 234, "/musicas/tenta acreditar.mp3", "Tenta Acreditar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "Musica_BId",
                keyValue: new Guid("4f83abdb-1bc4-42b6-afc8-bf75c7ad511e"));

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "Musica_BId",
                keyValue: new Guid("61d2efbe-1003-482b-a561-ed635a892f1e"));

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "Musica_BId",
                keyValue: new Guid("d7606613-d319-40e7-9086-10e1201939d5"));

            migrationBuilder.InsertData(
                table: "Fotos",
                columns: new[] { "Musica_BId", "Autor_B", "Duracao_B", "Ficheiro_B", "Titulo_B" },
                values: new object[,]
                {
                    { new Guid("042e632a-1ebb-4d39-b2b8-0d2b447d38da"), "Rubel", 422, "~/musicas/quadro verde", "Quadro Verde" },
                    { new Guid("ad63b0c4-c80e-427a-8f53-117825defa8a"), "5 a Seco", 199, "~/musicas/pensando bem", "Pensando Bem" },
                    { new Guid("c2ce0c0d-1c6d-4ce5-83f9-6672d7eabeff"), "Anavitória", 234, "~/musicas/tenta acreditar", "Tenta Acreditar" }
                });
        }
    }
}
