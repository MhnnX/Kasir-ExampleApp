using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kasir_ExampleApp.Migrations
{
    /// <inheritdoc />
    public partial class Add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Products",
                newName: "Stok");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "Harga_Jual");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "Nama_Barang");

            migrationBuilder.AddColumn<decimal>(
                name: "Harga_Beli",
                table: "Products",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Id_Kategori",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Id_Kategori",
                table: "Products",
                column: "Id_Kategori");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_Id_Kategori",
                table: "Products",
                column: "Id_Kategori",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_Id_Kategori",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Products_Id_Kategori",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Harga_Beli",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Id_Kategori",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Stok",
                table: "Products",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "Nama_Barang",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Harga_Jual",
                table: "Products",
                newName: "Price");
        }
    }
}
