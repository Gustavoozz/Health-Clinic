using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.healthclinic.Migrations
{
    /// <inheritdoc />
    public partial class DBv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Paciente",
                type: "DATE",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(11)");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "HorarioAgendamento",
                table: "Consulta",
                type: "TIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DataNascimento",
                table: "Paciente",
                type: "VARCHAR(11)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HorarioAgendamento",
                table: "Consulta",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "TIME");
        }
    }
}
