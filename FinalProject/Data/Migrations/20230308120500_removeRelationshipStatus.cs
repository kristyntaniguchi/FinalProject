using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Data.Migrations
{
    public partial class removeRelationshipStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dependents_RelationshipStatuses_RelationshipStatusId",
                table: "Dependents");

            migrationBuilder.DropTable(
                name: "RelationshipStatuses");

            migrationBuilder.DropIndex(
                name: "IX_Dependents_RelationshipStatusId",
                table: "Dependents");

            migrationBuilder.DropColumn(
                name: "RelationshipStatusId",
                table: "Dependents");

            migrationBuilder.AddColumn<string>(
                name: "RelationshipToSuperhero",
                table: "Dependents",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RelationshipToSuperhero",
                table: "Dependents");

            migrationBuilder.AddColumn<int>(
                name: "RelationshipStatusId",
                table: "Dependents",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RelationshipStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelationshipToSuperhero = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationshipStatuses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RelationshipStatuses",
                columns: new[] { "Id", "RelationshipToSuperhero" },
                values: new object[,]
                {
                    { 1, "Spouse" },
                    { 2, "Child" },
                    { 3, "Parent" },
                    { 4, "Sibling" },
                    { 5, "Grandparent" },
                    { 6, "Niece/Nephew" },
                    { 7, "Other" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dependents_RelationshipStatusId",
                table: "Dependents",
                column: "RelationshipStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dependents_RelationshipStatuses_RelationshipStatusId",
                table: "Dependents",
                column: "RelationshipStatusId",
                principalTable: "RelationshipStatuses",
                principalColumn: "Id");
        }
    }
}
