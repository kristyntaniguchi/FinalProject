using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Data.Migrations
{
    public partial class removeCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Superheroes_SuperheroCategories_SuperheroCategoryId",
                table: "Superheroes");

            migrationBuilder.DropTable(
                name: "SuperheroCategories");

            migrationBuilder.DropIndex(
                name: "IX_Superheroes_SuperheroCategoryId",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "RankId",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "SuperheroCategoryId",
                table: "Superheroes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RankId",
                table: "Superheroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SuperheroCategoryId",
                table: "Superheroes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SuperheroCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperheroCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Superheroes_SuperheroCategoryId",
                table: "Superheroes",
                column: "SuperheroCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Superheroes_SuperheroCategories_SuperheroCategoryId",
                table: "Superheroes",
                column: "SuperheroCategoryId",
                principalTable: "SuperheroCategories",
                principalColumn: "Id");
        }
    }
}
