using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionColegio.Persistence.EntityFramework.Migrations
{
    public partial class RelacionProfesorAsignatura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfesorId",
                table: "Asignaturas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_ProfesorId",
                table: "Asignaturas",
                column: "ProfesorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_Usuarios_ProfesorId",
                table: "Asignaturas",
                column: "ProfesorId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_Usuarios_ProfesorId",
                table: "Asignaturas");

            migrationBuilder.DropIndex(
                name: "IX_Asignaturas_ProfesorId",
                table: "Asignaturas");

            migrationBuilder.DropColumn(
                name: "ProfesorId",
                table: "Asignaturas");
        }
    }
}
