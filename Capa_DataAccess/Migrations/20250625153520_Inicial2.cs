using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Capa_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Inicial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmpleadoCedula",
                table: "Usuarios",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EmpleadoCedula",
                table: "Usuarios",
                column: "EmpleadoCedula");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Empleados_EmpleadoCedula",
                table: "Usuarios",
                column: "EmpleadoCedula",
                principalTable: "Empleados",
                principalColumn: "Cedula",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Empleados_EmpleadoCedula",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_EmpleadoCedula",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EmpleadoCedula",
                table: "Usuarios");
        }
    }
}
