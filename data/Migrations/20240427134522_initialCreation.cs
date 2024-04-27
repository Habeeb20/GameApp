using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gaming_Genre_GenreId",
                table: "Gaming");

            migrationBuilder.DropIndex(
                name: "IX_Gaming_GenreId",
                table: "Gaming");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Gaming");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Gaming",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Gaming");

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Gaming",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Gaming_GenreId",
                table: "Gaming",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gaming_Genre_GenreId",
                table: "Gaming",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
