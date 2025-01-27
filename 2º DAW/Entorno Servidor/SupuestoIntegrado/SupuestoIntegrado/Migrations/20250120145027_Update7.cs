using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupuestoIntegrado.Migrations
{
    /// <inheritdoc />
    public partial class Update7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carritos_Productos_ProductosId",
                table: "Carritos");

            migrationBuilder.DropForeignKey(
                name: "FK_Carritos_Usuarios_UsuariosId",
                table: "Carritos");

            migrationBuilder.DropForeignKey(
                name: "FK_ImagenesProductos_Productos_ProductoId",
                table: "ImagenesProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Roles_RolesId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_RolesId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_ImagenesProductos_ProductoId",
                table: "ImagenesProductos");

            migrationBuilder.DropIndex(
                name: "IX_Carritos_UsuariosId",
                table: "Carritos");

            migrationBuilder.AddColumn<int>(
                name: "ProductosId",
                table: "ImagenesProductos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Carritos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ImagenesProductos_ProductosId",
                table: "ImagenesProductos",
                column: "ProductosId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagenesProductos_Productos_ProductosId",
                table: "ImagenesProductos",
                column: "ProductosId",
                principalTable: "Productos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagenesProductos_Productos_ProductosId",
                table: "ImagenesProductos");

            migrationBuilder.DropIndex(
                name: "IX_ImagenesProductos_ProductosId",
                table: "ImagenesProductos");

            migrationBuilder.DropColumn(
                name: "ProductosId",
                table: "ImagenesProductos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Carritos");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolesId",
                table: "Usuarios",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagenesProductos_ProductoId",
                table: "ImagenesProductos",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carritos_UsuariosId",
                table: "Carritos",
                column: "UsuariosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carritos_Productos_ProductosId",
                table: "Carritos",
                column: "ProductosId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carritos_Usuarios_UsuariosId",
                table: "Carritos",
                column: "UsuariosId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
