using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieAPI.DAL.Migrations
{
    public partial class listComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Movies",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Comments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MoviesId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MoviesId",
                table: "Comments",
                column: "MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Movies_MoviesId",
                table: "Comments",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Movies_MoviesId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_MoviesId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "MoviesId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Movies",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Comments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
