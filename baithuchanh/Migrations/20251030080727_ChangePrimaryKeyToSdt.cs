using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace baithuchanh.Migrations
{
    /// <inheritdoc />
    public partial class ChangePrimaryKeyToSdt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien");

            migrationBuilder.AlterColumn<string>(
                name: "NhanVienId",
                table: "NhanVien",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Sdt",
                table: "NhanVien",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien",
                column: "Sdt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "Sdt",
                table: "NhanVien");

            migrationBuilder.AlterColumn<string>(
                name: "NhanVienId",
                table: "NhanVien",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien",
                column: "NhanVienId");
        }
    }
}
