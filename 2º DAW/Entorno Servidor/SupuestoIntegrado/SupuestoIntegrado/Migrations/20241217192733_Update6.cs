using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupuestoIntegrado.Migrations
{
    /// <inheritdoc />
    public partial class Update6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagenesProductos_Productos_ProductoId",
                table: "ImagenesProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Roles_RolesId",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "RolesId",
                table: "Usuarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductoId",
                table: "ImagenesProductos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagenesProductos_Productos_ProductoId",
                table: "ImagenesProductos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Roles_RolesId",
                table: "Usuarios",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagenesProductos_Productos_ProductoId",
                table: "ImagenesProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Roles_RolesId",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "RolesId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductoId",
                table: "ImagenesProductos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ImagenesProductos_Productos_ProductoId",
                table: "ImagenesProductos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Roles_RolesId",
                table: "Usuarios",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
