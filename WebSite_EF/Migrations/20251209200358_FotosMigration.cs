using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebSite_EF.Migrations
{
    /// <inheritdoc />
    public partial class FotosMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fotos",
                columns: table => new
                {
                    FotoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotos", x => x.FotoId);
                });

            migrationBuilder.InsertData(
                table: "Fotos",
                columns: new[] { "FotoId", "Autor", "Codigo", "Preco", "Titulo" },
                values: new object[,]
                {
                    { new Guid("8f1843d7-92d1-4264-aa14-69b8ef235dac"), "Sebastião Salgado", 123455, 500.00m, "Terra" },
                    { new Guid("a9e39a00-b8d2-4fe7-87e0-71d67a2a50ae"), "Eduardo Gageiro ", 123466, 100.00m, "Lisboa" },
                    { new Guid("e2592c77-400d-4449-887f-83d7be49f261"), "Eduardo Gageiro ", 123477, 100.00m, "Lisboa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fotos");
        }
    }
}
