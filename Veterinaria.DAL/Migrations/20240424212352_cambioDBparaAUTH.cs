using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Veterinaria.DAL.Migrations
{
    /// <inheritdoc />
    public partial class cambioDBparaAUTH : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Clientes_ClienteId",
                table: "Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Veterinario_VeterinarioId",
                table: "Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Clientes_ClienteId",
                table: "Mascotas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Veterinario");

            migrationBuilder.DropIndex(
                name: "IX_Mascotas_ClienteId",
                table: "Mascotas");

            migrationBuilder.DropIndex(
                name: "IX_Consulta_ClienteId",
                table: "Consulta");

            migrationBuilder.DropIndex(
                name: "IX_Consulta_VeterinarioId",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Mascotas");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "VeterinarioId",
                table: "Consulta");

            migrationBuilder.AddColumn<string>(
                name: "CreacionMascotaId",
                table: "Mascotas",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConsultaCreacionId",
                table: "Consulta",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");


            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_CreacionMascotaId",
                table: "Mascotas",
                column: "CreacionMascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_ConsultaCreacionId",
                table: "Consulta",
                column: "ConsultaCreacionId");

            

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_AspNetUsers_ConsultaCreacionId",
                table: "Consulta",
                column: "ConsultaCreacionId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_AspNetUsers_CreacionMascotaId",
                table: "Mascotas",
                column: "CreacionMascotaId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_AspNetUsers_ConsultaCreacionId",
                table: "Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_AspNetUsers_CreacionMascotaId",
                table: "Mascotas");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropIndex(
                name: "IX_Mascotas_CreacionMascotaId",
                table: "Mascotas");

            migrationBuilder.DropIndex(
                name: "IX_Consulta_ConsultaCreacionId",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "CreacionMascotaId",
                table: "Mascotas");

            migrationBuilder.DropColumn(
                name: "ConsultaCreacionId",
                table: "Consulta");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Mascotas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Consulta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VeterinarioId",
                table: "Consulta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinario", x => x.IdVeterinario);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_ClienteId",
                table: "Mascotas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_ClienteId",
                table: "Consulta",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_VeterinarioId",
                table: "Consulta",
                column: "VeterinarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Clientes_ClienteId",
                table: "Consulta",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Veterinario_VeterinarioId",
                table: "Consulta",
                column: "VeterinarioId",
                principalTable: "Veterinario",
                principalColumn: "IdVeterinario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Clientes_ClienteId",
                table: "Mascotas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
