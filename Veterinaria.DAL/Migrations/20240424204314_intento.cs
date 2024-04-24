using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Veterinaria.DAL.Migrations
{
    /// <inheritdoc />
    public partial class intento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Veterinario",
                columns: table => new
                {
                    IdVeterinario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinario", x => x.IdVeterinario);
                });

            migrationBuilder.CreateTable(
                name: "Mascotas",
                columns: table => new
                {
                    IdMascotas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    Dueño = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Padecimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagenMascota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascotas", x => x.IdMascotas);
                    table.ForeignKey(
                        name: "FK_Mascotas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    IdConsulta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimeValue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tratamiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Medicamentos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VeterinarioId = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    MascotaIdMascotas = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.IdConsulta);
                    table.ForeignKey(
                        name: "FK_Consulta_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consulta_Mascotas_MascotaIdMascotas",
                        column: x => x.MascotaIdMascotas,
                        principalTable: "Mascotas",
                        principalColumn: "IdMascotas");
                    table.ForeignKey(
                        name: "FK_Consulta_Veterinario_VeterinarioId",
                        column: x => x.VeterinarioId,
                        principalTable: "Veterinario",
                        principalColumn: "IdVeterinario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_ClienteId",
                table: "Consulta",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_MascotaIdMascotas",
                table: "Consulta",
                column: "MascotaIdMascotas");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_VeterinarioId",
                table: "Consulta",
                column: "VeterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_ClienteId",
                table: "Mascotas",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consulta");

            migrationBuilder.DropTable(
                name: "Mascotas");

            migrationBuilder.DropTable(
                name: "Veterinario");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
