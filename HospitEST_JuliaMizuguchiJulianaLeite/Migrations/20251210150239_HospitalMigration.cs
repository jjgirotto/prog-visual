using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitEST_JuliaMizuguchiJulianaLeite.Migrations
{
    /// <inheritdoc />
    public partial class HospitalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospital_JMJL",
                columns: table => new
                {
                    Id_JMJL = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name_JMJL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_JMJL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital_JMJL", x => x.Id_JMJL);
                });

            migrationBuilder.CreateTable(
                name: "Doctor_JMJL",
                columns: table => new
                {
                    Id_JMJL = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Hospital_JMJLId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name_JMJL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Practice_JMJL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PracticeYears_JMJL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor_JMJL", x => x.Id_JMJL);
                    table.ForeignKey(
                        name: "FK_Doctor_JMJL_Hospital_JMJL_Hospital_JMJLId",
                        column: x => x.Hospital_JMJLId,
                        principalTable: "Hospital_JMJL",
                        principalColumn: "Id_JMJL",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patient_JMJL",
                columns: table => new
                {
                    Id_JMJL = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Doctor_JMJLId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name_JMJL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth_JMJL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pathology_JMJL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient_JMJL", x => x.Id_JMJL);
                    table.ForeignKey(
                        name: "FK_Patient_JMJL_Doctor_JMJL_Doctor_JMJLId",
                        column: x => x.Doctor_JMJLId,
                        principalTable: "Doctor_JMJL",
                        principalColumn: "Id_JMJL",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hospital_JMJL",
                columns: new[] { "Id_JMJL", "Location_JMJL", "Name_JMJL" },
                values: new object[,]
                {
                    { new Guid("8b5491dc-7dfa-41f2-bc93-0e3f0fe66b5d"), "Lisboa", "Centro Hospitalar Lisboa Norte" },
                    { new Guid("ed8cfb19-c92f-4413-ac00-2a2bc41cafb2"), "Setúbal", "Centro Hospitalara de Setúbal" }
                });

            migrationBuilder.InsertData(
                table: "Doctor_JMJL",
                columns: new[] { "Id_JMJL", "Hospital_JMJLId", "Name_JMJL", "PracticeYears_JMJL", "Practice_JMJL" },
                values: new object[,]
                {
                    { new Guid("08cd38b0-8926-4a33-942a-eec6bcdaaadc"), new Guid("8b5491dc-7dfa-41f2-bc93-0e3f0fe66b5d"), "Manuel Esteves", 13, "Medicina Geral e Familiar" },
                    { new Guid("b2a208c5-1c2c-4149-a678-51991ec0aa85"), new Guid("8b5491dc-7dfa-41f2-bc93-0e3f0fe66b5d"), "Luis Silva", 19, "Neurocirurgião" },
                    { new Guid("b6f98f2f-cecc-466c-a54a-7e23598c5fb7"), new Guid("ed8cfb19-c92f-4413-ac00-2a2bc41cafb2"), "Miguel Neves", 13, "Ortopedista" },
                    { new Guid("e2ec207c-1a71-45cb-a948-10b20074b336"), new Guid("ed8cfb19-c92f-4413-ac00-2a2bc41cafb2"), "Sofia Feliz", 4, "Pediatra" }
                });

            migrationBuilder.InsertData(
                table: "Patient_JMJL",
                columns: new[] { "Id_JMJL", "DateOfBirth_JMJL", "Doctor_JMJLId", "Name_JMJL", "Pathology_JMJL" },
                values: new object[,]
                {
                    { new Guid("0c7fa654-2b21-4c7a-a7f4-24dbafdfc75e"), new DateTime(1984, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("08cd38b0-8926-4a33-942a-eec6bcdaaadc"), "Ana Júlia Araújo", "Gripe" },
                    { new Guid("5014f8bc-21e3-4dac-aa81-4743b8d7bebf"), new DateTime(1990, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2a208c5-1c2c-4149-a678-51991ec0aa85"), "Bernardo Pereira", "Traumatismo Craniano" },
                    { new Guid("58c1465f-1a06-43e0-81fa-6d78b9a9dd78"), new DateTime(1990, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2a208c5-1c2c-4149-a678-51991ec0aa85"), "Otávio Campos", "Tumor no cérebro" },
                    { new Guid("768ae238-6063-4366-aace-78723320fb58"), new DateTime(2001, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b6f98f2f-cecc-466c-a54a-7e23598c5fb7"), "David Nogueira", "Ombro deslocado" },
                    { new Guid("795674c3-2ebe-499a-8a02-864a7be69651"), new DateTime(2019, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e2ec207c-1a71-45cb-a948-10b20074b336"), "Maitê Alves", "Asperger" },
                    { new Guid("98cac64c-71b4-4201-bb19-a63a3c0099af"), new DateTime(2004, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b6f98f2f-cecc-466c-a54a-7e23598c5fb7"), "António Campos", "Perna partida" },
                    { new Guid("9d49481a-a989-414e-9546-3f3f190f95ee"), new DateTime(2005, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b6f98f2f-cecc-466c-a54a-7e23598c5fb7"), "Daniel Moreira", "Cotovelo Rachado" },
                    { new Guid("d4086df1-b10d-42d0-b1df-9db796924b26"), new DateTime(1957, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2a208c5-1c2c-4149-a678-51991ec0aa85"), "Helena Porto", "AVC" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_JMJL_Hospital_JMJLId",
                table: "Doctor_JMJL",
                column: "Hospital_JMJLId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_JMJL_Doctor_JMJLId",
                table: "Patient_JMJL",
                column: "Doctor_JMJLId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patient_JMJL");

            migrationBuilder.DropTable(
                name: "Doctor_JMJL");

            migrationBuilder.DropTable(
                name: "Hospital_JMJL");
        }
    }
}
