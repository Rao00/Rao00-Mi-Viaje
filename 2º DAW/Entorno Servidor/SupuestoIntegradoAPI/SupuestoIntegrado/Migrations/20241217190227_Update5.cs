using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupuestoIntegrado.Migrations
{
    /// <inheritdoc />
    public partial class Update5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carritos_Productos_ProductId",
                table: "Carritos");

            migrationBuilder.DropForeignKey(
                name: "FK_Carritos_Usuarios_UserId",
                table: "Carritos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carritos",
                table: "Carritos");

            migrationBuilder.DropIndex(
                name: "IX_Carritos_ProductId",
                table: "Carritos");

            migrationBuilder.DropColumn(
                name: "IdRole",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "ImagenesProductos");

            migrationBuilder.DropColumn(
                name: "IdProduct",
                table: "Carritos");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Carritos");

            migrationBuilder.RenameColumn(
                name: "Contraseña",
                table: "Usuarios",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "TipoRole",
                table: "Roles",
                newName: "DescripcionRol");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Productos",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Carritos",
                newName: "UsuariosId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Carritos",
                newName: "ProductosId");

            migrationBuilder.RenameIndex(
                name: "IX_Carritos_UserId",
                table: "Carritos",
                newName: "IX_Carritos_UsuariosId");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "ImagenesProductos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Cantidad",
                table: "Carritos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carritos",
                table: "Carritos",
                columns: new[] { "ProductosId", "UsuariosId" });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carritos_Productos_ProductosId",
                table: "Carritos");

            migrationBuilder.DropForeignKey(
                name: "FK_Carritos_Usuarios_UsuariosId",
                table: "Carritos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carritos",
                table: "Carritos");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Usuarios",
                newName: "Contraseña");

            migrationBuilder.RenameColumn(
                name: "DescripcionRol",
                table: "Roles",
                newName: "TipoRole");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Productos",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "UsuariosId",
                table: "Carritos",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ProductosId",
                table: "Carritos",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Carritos_UsuariosId",
                table: "Carritos",
                newName: "IX_Carritos_UserId");

            migrationBuilder.AddColumn<string>(
                name: "IdRole",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "ImagenesProductos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProducto",
                table: "ImagenesProductos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Cantidad",
                table: "Carritos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProduct",
                table: "Carritos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Carritos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carritos",
                table: "Carritos",
                columns: new[] { "IdProduct", "IdUser" });

            migrationBuilder.CreateIndex(
                name: "IX_Carritos_ProductId",
                table: "Carritos",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carritos_Productos_ProductId",
                table: "Carritos",
                column: "ProductId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carritos_Usuarios_UserId",
                table: "Carritos",
                column: "UserId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
