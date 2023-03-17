using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Data.Migrations
{
    public partial class changeRelationshipStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relationships_RelationshipStatuses_RelationshipStatusId",
                table: "Relationships");

            migrationBuilder.DropIndex(
                name: "IX_Relationships_RelationshipStatusId",
                table: "Relationships");

            migrationBuilder.DropColumn(
                name: "RelationshipStatusId",
                table: "Relationships");

            migrationBuilder.AddColumn<int>(
                name: "RelationshipStatusId",
                table: "Dependents",
                type: "int",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "SuperheroStatuses",
                columns: new[] { "Id", "StatusTitle" },
                values: new object[,]
                {
                    { 1, "Active" },
                    { 2, "Inactive" },
                    { 3, "Terminated" },
                    { 4, "Deceased" }
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dependents_RelationshipStatuses_RelationshipStatusId",
                table: "Dependents");

            migrationBuilder.DropIndex(
                name: "IX_Dependents_RelationshipStatusId",
                table: "Dependents");

            migrationBuilder.DeleteData(
                table: "RelationshipStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RelationshipStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RelationshipStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RelationshipStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RelationshipStatuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RelationshipStatuses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RelationshipStatuses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SuperheroStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SuperheroStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SuperheroStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SuperheroStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "RelationshipStatusId",
                table: "Dependents");

            migrationBuilder.AddColumn<int>(
                name: "RelationshipStatusId",
                table: "Relationships",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Relationships_RelationshipStatusId",
                table: "Relationships",
                column: "RelationshipStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_RelationshipStatuses_RelationshipStatusId",
                table: "Relationships",
                column: "RelationshipStatusId",
                principalTable: "RelationshipStatuses",
                principalColumn: "Id");
        }
    }
}
