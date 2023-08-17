using Microsoft.EntityFrameworkCore.Migrations;

namespace WireFrames.Data.Migrations
{
    public partial class migEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Photos_PhotoID",
                table: "Tags");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Tags",
                newName: "TagID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Photos",
                newName: "PhotoID");

            migrationBuilder.AlterColumn<int>(
                name: "PhotoID",
                table: "Tags",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Photos_PhotoID",
                table: "Tags",
                column: "PhotoID",
                principalTable: "Photos",
                principalColumn: "PhotoID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Photos_PhotoID",
                table: "Tags");

            migrationBuilder.RenameColumn(
                name: "TagID",
                table: "Tags",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "PhotoID",
                table: "Photos",
                newName: "ID");

            migrationBuilder.AlterColumn<int>(
                name: "PhotoID",
                table: "Tags",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Photos_PhotoID",
                table: "Tags",
                column: "PhotoID",
                principalTable: "Photos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
