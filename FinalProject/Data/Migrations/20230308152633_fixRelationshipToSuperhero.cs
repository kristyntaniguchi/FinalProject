using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Data.Migrations
{
    public partial class fixRelationshipToSuperhero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Relationship",
                table: "Dependents",
                newName: "RelationshipToSuperhero");

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegistrationDate",
                value: new DateTime(2006, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RelationshipToSuperhero",
                table: "Dependents",
                newName: "Relationship");

            migrationBuilder.UpdateData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegistrationDate",
                value: new DateTime(2023, 3, 8, 7, 13, 11, 478, DateTimeKind.Local).AddTicks(3216));
        }
    }
}
