using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Data.Migrations
{
    public partial class updatingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RelationshipToSuperhero",
                table: "Dependents",
                newName: "Relationship");

            migrationBuilder.InsertData(
                table: "Agencies",
                columns: new[] { "Id", "City", "Country", "Insignia", "Name", "PostalCode", "StateOrProvince", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Sacramento", "USA", null, "Federal Bureau of Inadequate Superheroes", "94203", "California", "381 Macaroni St" },
                    { 2, "Danville", "USA", null, "Organization Without a Cool Acronym", "90095", "Tri-State Area", "104 Summer Ave" },
                    { 3, "Santa Barbara", "USA", null, "Santa Barbara Police Department", "93101", "California", "215 EnFigueroa St" },
                    { 4, "Hanalei", "USA", null, "Galactic Federation", "96714", "Hawaii", "2002 Lilo Way" },
                    { 5, "Langley", "USA", null, "Clearly Ineffective Abilities", "23454", "Virginia", "1000 Colonial Farm Road" },
                    { 6, "Washington", "USA", null, "Unfortunate Superpowers Performance Service", "20260", "D.C.", "475 L'Enfant Plaza SW" }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Abilities", "AgencyId", "City", "Country", "DateOfBirth", "Email", "FirstName", "LastName", "Nationality", "Notes", "Phone", "Photo", "PostalCode", "RegistrationDate", "RegistrationId", "StateOrProvince", "StreetAddress", "SuperheroName", "SuperheroStatusId" },
                values: new object[,]
                {
                    { 1, "Uncontrollable aging, both forwards and backwards.", 2, "Renton", "USA", new DateTime(2003, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "BenjaminButtoning1@gmail.com", "Jack", "Son", "American", "Symptoms are exasperated by synchronous diaphragmatic flutter (hiccupping)", "2068893720", null, "98057", new DateTime(2018, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OWCA37209092", "Washington", "9092 Minecraft Blvd.", "N/A", 1 },
                    { 2, "Laser vision.", 6, "Crocker", "USA", new DateTime(1998, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nedward@gmail.com", "Ned", "Ward", "American", "Low power.  Takes 4 minutes to toast one side of a slice of bread.", "4253334567", null, "35004", new DateTime(2008, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "USPS45675435", "Alabama", "5435 Pillsbury Blvd.", "Toaster Dude-le", 2 },
                    { 3, "Can turn any bread food item into a waffle by singing it a song.\r\nCries tears of maple syrup.", 4, "Kihei", "USA", new DateTime(1988, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "LeggoMyGreggo@gmail.com", "Greg", "Porter", "Canadian", "Known waffle flavors: Chocolate chip, banana, cinnamon sugar, pumpkin, and blueberry.  \nTears are  genuine maple syrup.", "4355772765", null, "96272", new DateTime(2005, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GFHI27653728", "Hawaii", "3728 Aulani Dr.", "Gr-Eggo", 3 },
                    { 4, "Telekinetically moves shopping carts.", 6, "Renton", "USA", new DateTime(1994, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hannah@gmail.com", "Hannah", "Angel", "American", "Known member of the NW Shopping Cart Racing Ring.", "4259765436", null, "98056", new DateTime(2015, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "USPS283927348", "Washington", "666 Fire St. Apt. 212", "N/A", 1 },
                    { 5, "Generates energy and healing capabilities by consuming food that's fallen on the floor.", 6, "Renton", "USA", new DateTime(1997, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "DylanBrotato@gmail.com", "Dylan", "Register", "American", "Frequently finds chicken on the floor in unexpected places.", "2063436546", null, "98056", new DateTime(2015, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "USPS393943A8", "Washington", "666 Fire St. Apt. 213", "N/A", 1 },
                    { 6, "Can communicate with raccoons, squirrels, and crows.", 6, "Renton", "USA", new DateTime(1997, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kristyn2@gmail.com", "Kristyn", "Taniguchi", "American", "Has trained them to annoy her enemies.", "2064440875", null, "98056", new DateTime(2015, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "USPS54546568", "Washington", "666 Fire St. Apt. 214", "N/A", 1 },
                    { 7, "Hair changes color based on their mood.", 6, "Renton", "USA", new DateTime(1983, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "WillCramComputerScienceMan@gmail.com", "Will", "Cram", "American", "He is bald.", "4257668765", null, "98056", new DateTime(2015, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "USPS84293JH", "Washington", "666 Fire St. Apt. 215", "N/A", 1 },
                    { 8, "Night vision.", 6, "Renton", "USA", new DateTime(1986, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Josh9@gmail.com", "Josh", "Emery", "American", "Must wear prescription sunglasses to see during the day.", "4252223029", null, "98056", new DateTime(2015, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "USPS8393474JJ", "Washington", "666 Fire St. Apt. 216", "N/A", 1 },
                    { 9, "Exhales helium. \nExtremely large lung capacity.", 5, "Halifax", "Canada", new DateTime(1983, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "BaileysBalloon@gmail.com", "Bailey", "Mylar", "Canadian", "The sound of her voice is always affected by helium. \nMakes balloon arches for pet adoption events. \nHas not been seen since The Great Hot Air Balloon Accident of 2018.", "3422326546", null, "B0N 1Y0", new DateTime(2012, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "CIA7439USX", "Nova Scotia", "839 Abbey Rd.", "Bailoony", 2 },
                    { 10, "Can tell someone's birthday based off their \"vibe\".", 1, "Newport Beach", "USA", new DateTime(1999, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haleyscope@gmail.com", "Haley", "Girardi", "American", "Big fan of astrology.  \nTerminated for refusing to work with Libras.", "9758431028", null, "92660", new DateTime(2017, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "FBIS02938KBT", "California", "1111 Aquarius Way", "N/A", 3 },
                    { 11, "Causes decomposing materials to combust whenever he wins Rock, Paper, Scissors.", 3, "Eugene", "USA", new DateTime(1992, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jimardson@gmail.com", "Jimmy", "Richardson", "American", "Has a history of accidental arson. \nSpent 7 months on the FBI's Most Wanted list for starting a fire on an airplane midflight.", "4324590914", null, "97408", new DateTime(2014, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "SBPD83947UWT", "Oregon", "1091 Sandwich Rd.", "Dumpster Fire", 2 },
                    { 12, "Finger scissors are actual working scissors.", 4, "Denver", "USA", new DateTime(1992, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "racecarracecar@gmail.com", "Levi", "Ivel", "Canadian", "Cause of death was due to him unintentionally severing his cable while bungee jumping.", "7289283341", null, "80204", new DateTime(2014, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "GFHI92GG7P0", "Colorado", "222 Skyview Ave.", "", 4 },
                    { 13, "Can taste the pH level of substances.", 5, "Denver", "USA", new DateTime(1986, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "pHoShizzle@gmail.com", "Tony", "Dunn", "British", "Cause of death was poisoning due to ingesting a multitude of toxic chemicals while testing their pH level.  No foul play suspected.", "7355520755", null, "80210", new DateTime(2023, 3, 8, 7, 13, 11, 478, DateTimeKind.Local).AddTicks(3216), "HELP73834ME7", "Colorado", "92038 Substrate St.", "pH Taster", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.RenameColumn(
                name: "Relationship",
                table: "Dependents",
                newName: "RelationshipToSuperhero");
        }
    }
}
