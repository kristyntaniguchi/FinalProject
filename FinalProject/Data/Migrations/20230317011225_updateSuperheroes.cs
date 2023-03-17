using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Data.Migrations
{
    public partial class updateSuperheroes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DependentSuperhero");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "RelationshipToSuperhero",
                table: "Dependents");

            migrationBuilder.RenameColumn(
                name: "StateOrProvince",
                table: "Superheroes",
                newName: "State");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Superheroes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58);

            migrationBuilder.AddColumn<string>(
                name: "RelationshipToSuperhero",
                table: "Relationships",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Abilities", "SuperheroName" },
                values: new object[] { "Hair changes color based on his mood.", "Matchstick" });

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Notes",
                value: "Lighting above 100 lumens is blinding. Must wear custom made prescription sunglasses during the day.");

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "PostalCode", "State" },
                values: new object[] { "Portland", "92211", "Oregon" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RelationshipToSuperhero",
                table: "Relationships");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Superheroes",
                newName: "StateOrProvince");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Superheroes",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Superheroes",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Superheroes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RelationshipToSuperhero",
                table: "Dependents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DependentSuperhero",
                columns: table => new
                {
                    DependentsId = table.Column<int>(type: "int", nullable: false),
                    SuperheroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DependentSuperhero", x => new { x.DependentsId, x.SuperheroId });
                    table.ForeignKey(
                        name: "FK_DependentSuperhero_Dependents_DependentsId",
                        column: x => x.DependentsId,
                        principalTable: "Dependents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DependentSuperhero_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Country", "Nationality" },
                values: new object[] { "USA", "American" });

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Country", "Nationality" },
                values: new object[] { "USA", "American" });

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Country", "Nationality" },
                values: new object[] { "USA", "Canadian" });

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Country", "Nationality" },
                values: new object[] { "USA", "American" });

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Country", "Nationality" },
                values: new object[] { "USA", "American" });

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Country", "Nationality" },
                values: new object[] { "USA", "American" });

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Abilities", "Country", "Nationality", "SuperheroName" },
                values: new object[] { "Hair changes color based on their mood.", "USA", "American", "N/A" });

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Country", "Nationality", "Notes" },
                values: new object[] { "USA", "American", "Must wear prescription sunglasses to see during the day." });

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "Nationality", "PostalCode", "StateOrProvince" },
                values: new object[] { "Halifax", "Canada", "Canadian", "B0N 1Y0", "Nova Scotia" });

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Country", "Nationality" },
                values: new object[] { "USA", "American" });

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Country", "Nationality" },
                values: new object[] { "USA", "American" });

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Country", "Nationality" },
                values: new object[] { "USA", "Canadian" });

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Country", "Nationality" },
                values: new object[] { "USA", "British" });

            migrationBuilder.CreateIndex(
                name: "IX_DependentSuperhero_SuperheroId",
                table: "DependentSuperhero",
                column: "SuperheroId");
        }
    }
}
