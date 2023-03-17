using FinalProject.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    //Inherits from IdentityDbContext
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }//End of the Constructor

        //Add all the tables/models as DbSet<t>.  Add using statement.
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Dependent> Dependents { get; set; }
        public DbSet<Relationship> Relationships { get; set; }
        public DbSet<Superhero> Superheroes { get; set; }
        public DbSet<SuperheroStatus> SuperheroStatuses { get; set; }

        //Add the migration is the package manager: add-migration migrationName.  Then update database: update-database


        //Can add seed data
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //SuperheroStatus==========================================================
            builder.Entity<SuperheroStatus>().HasData(
                new SuperheroStatus { Id = 1, StatusTitle = "Active" },
                new SuperheroStatus { Id = 2, StatusTitle = "Inactive" },
                new SuperheroStatus { Id = 3, StatusTitle = "Terminated" },
                new SuperheroStatus { Id = 4, StatusTitle = "Deceased" }
                );
            //base.OnModelCreating(builder);

            ////RelationshipStatus==========================================================
            //builder.Entity<RelationshipStatus>().HasData(
            //    new RelationshipStatus { Id = 1, RelationshipToSuperhero = "Spouse" },
            //    new RelationshipStatus { Id = 2, RelationshipToSuperhero = "Child" },
            //    new RelationshipStatus { Id = 3, RelationshipToSuperhero = "Parent" },
            //    new RelationshipStatus { Id = 4, RelationshipToSuperhero = "Sibling" },
            //    new RelationshipStatus { Id = 5, RelationshipToSuperhero = "Grandparent" },
            //    new RelationshipStatus { Id = 6, RelationshipToSuperhero = "Niece/Nephew" },
            //    new RelationshipStatus { Id = 7, RelationshipToSuperhero = "Other" }
            //    );

            //Agencies=======================================================================
            builder.Entity<Agency>().HasData(
                new Agency { Id = 1, Name = "Federal Bureau of Inadequate Superheroes", StreetAddress = "381 Macaroni St", City = "Sacramento", StateOrProvince = "California", Country = "USA", PostalCode = "94203" },
                new Agency { Id = 2, Name = "Organization Without a Cool Acronym", StreetAddress = "104 Summer Ave", City = "Danville", StateOrProvince = "Tri-State Area", Country = "USA", PostalCode = "90095" },
                new Agency { Id = 3, Name = "Santa Barbara Police Department", StreetAddress = "215 EnFigueroa St", City = "Santa Barbara", StateOrProvince = "California", Country = "USA", PostalCode = "93101" },
                new Agency { Id = 4, Name = "Galactic Federation", StreetAddress = "2002 Lilo Way", City = "Hanalei", StateOrProvince = "Hawaii", Country = "USA", PostalCode = "96714" },
                new Agency { Id = 5, Name = "Clearly Ineffective Abilities", StreetAddress = "1000 Colonial Farm Road", City = "Langley", StateOrProvince = "Virginia", Country = "USA", PostalCode = "23454" },
                new Agency { Id = 6, Name = "Unfortunate Superpowers Performance Service", StreetAddress = "475 L'Enfant Plaza SW", City = "Washington", StateOrProvince = "D.C.", Country = "USA", PostalCode = "20260" }
                );

            //Superheroes====================================================================
            builder.Entity<Superhero>().HasData(
                 new Superhero { Id = 1, SuperheroName = "N/A", FirstName = "Jack", LastName = "Son", Phone = "2068893720", Email = "BenjaminButtoning1@gmail.com", Abilities = "Uncontrollable aging, both forwards and backwards.", Notes = "Symptoms are exasperated by synchronous diaphragmatic flutter (hiccupping)", DateOfBirth = new DateTime(2003, 12, 30), AgencyId = 2, StreetAddress = "9092 Minecraft Blvd.", City = "Renton", State = "Washington", PostalCode = "98057", RegistrationId = "OWCA37209092", RegistrationDate = new DateTime(2018, 1, 21), SuperheroStatusId = 1 },
                 new Superhero { Id = 2, SuperheroName = "Toaster Dude-le", FirstName = "Ned", LastName = "Ward", Phone = "4253334567", Email = "Nedward@gmail.com", Abilities = "Laser vision.", Notes = "Low power.  Takes 4 minutes to toast one side of a slice of bread.", DateOfBirth = new DateTime(1998, 5, 30), AgencyId = 6, StreetAddress = "5435 Pillsbury Blvd.", City = "Crocker", State = "Alabama", PostalCode = "35004", RegistrationId = "USPS45675435", RegistrationDate = new DateTime(2008, 1, 21), SuperheroStatusId = 2 },
                 new Superhero { Id = 3, SuperheroName = "Gr-Eggo", FirstName = "Greg", LastName = "Porter", Phone = "4355772765", Email = "LeggoMyGreggo@gmail.com", Abilities = "Can turn any bread food item into a waffle by singing it a song.\r\nCries tears of maple syrup.", Notes = "Known waffle flavors: Chocolate chip, banana, cinnamon sugar, pumpkin, and blueberry.  \nTears are  genuine maple syrup.", DateOfBirth = new DateTime(1988, 3, 19), AgencyId = 4, StreetAddress = "3728 Aulani Dr.", City = "Kihei", State = "Hawaii", PostalCode = "96272", RegistrationId = "GFHI27653728", RegistrationDate = new DateTime(2005, 11, 1), SuperheroStatusId = 3 },
                 new Superhero { Id = 4, SuperheroName = "N/A", FirstName = "Hannah", LastName = "Angel", Phone = "4259765436", Email = "Hannah@gmail.com", Abilities = "Telekinetically moves shopping carts.", Notes = "Known member of the NW Shopping Cart Racing Ring.", DateOfBirth = new DateTime(1994, 5, 19), AgencyId = 6, StreetAddress = "666 Fire St. Apt. 212", City = "Renton", State = "Washington", PostalCode = "98056", RegistrationId = "USPS283927348", RegistrationDate = new DateTime(2015, 8, 23), SuperheroStatusId = 1 },
                 new Superhero { Id = 5, SuperheroName = "N/A", FirstName = "Dylan", LastName = "Register", Phone = "2063436546", Email = "DylanBrotato@gmail.com", Abilities = "Generates energy and healing capabilities by consuming food that's fallen on the floor.", Notes = "Frequently finds chicken on the floor in unexpected places.", DateOfBirth = new DateTime(1997, 8, 12), AgencyId = 6, StreetAddress = "666 Fire St. Apt. 213", City = "Renton", State = "Washington", PostalCode = "98056", RegistrationId = "USPS393943A8", RegistrationDate = new DateTime(2015, 8, 23), SuperheroStatusId = 1 },
                 new Superhero { Id = 6, SuperheroName = "N/A", FirstName = "Kristyn", LastName = "Taniguchi", Phone = "2064440875", Email = "Kristyn2@gmail.com", Abilities = "Can communicate with raccoons, squirrels, and crows.", Notes = "Has trained them to annoy her enemies.", DateOfBirth = new DateTime(1997, 8, 12), AgencyId = 6, StreetAddress = "666 Fire St. Apt. 214", City = "Renton", State = "Washington", PostalCode = "98056", RegistrationId = "USPS54546568", RegistrationDate = new DateTime(2015, 8, 23), SuperheroStatusId = 1 },
                 new Superhero { Id = 7, SuperheroName = "Matchstick", FirstName = "Will", LastName = "Cram", Phone = "4257668765", Email = "WillCramComputerScienceMan@gmail.com", Abilities = "Hair changes color based on his mood.", Notes = "He is bald.", DateOfBirth = new DateTime(1983, 9, 12), AgencyId = 6, StreetAddress = "666 Fire St. Apt. 215", City = "Renton", State = "Washington", PostalCode = "98056", RegistrationId = "USPS84293JH", RegistrationDate = new DateTime(2015, 8, 23), SuperheroStatusId = 1 },
                 new Superhero { Id = 8, SuperheroName = "N/A", FirstName = "Josh", LastName = "Emery", Phone = "4252223029", Email = "Josh9@gmail.com", Abilities = "Night vision.", Notes = "Lighting above 100 lumens is blinding. Must wear custom made prescription sunglasses during the day.", DateOfBirth = new DateTime(1986, 8, 22), AgencyId = 6, StreetAddress = "666 Fire St. Apt. 216", City = "Renton", State = "Washington", PostalCode = "98056", RegistrationId = "USPS8393474JJ", RegistrationDate = new DateTime(2015, 8, 23), SuperheroStatusId = 1 },
                  new Superhero { Id = 9, SuperheroName = "Bailoony", FirstName = "Bailey", LastName = "Mylar", Phone = "3422326546", Email = "BaileysBalloon@gmail.com", Abilities = "Exhales helium. \nExtremely large lung capacity.", Notes = "The sound of her voice is always affected by helium. \nMakes balloon arches for pet adoption events. \nHas not been seen since The Great Hot Air Balloon Accident of 2018.", DateOfBirth = new DateTime(1983, 8, 22), AgencyId = 5, StreetAddress = "839 Abbey Rd.", City = "Portland", State = "Oregon", PostalCode = "92211", RegistrationId = "CIA7439USX", RegistrationDate = new DateTime(2012, 2, 13), SuperheroStatusId = 2 },
                  new Superhero { Id = 10, SuperheroName = "N/A", FirstName = "Haley", LastName = "Girardi", Phone = "9758431028",  Email = "Haleyscope@gmail.com", Abilities = "Can tell someone's birthday based off their \"vibe\".", Notes = "Big fan of astrology.  \nTerminated for refusing to work with Libras.", DateOfBirth = new DateTime(1999, 8, 2), AgencyId = 1, StreetAddress = "1111 Aquarius Way", City = "Newport Beach", State = "California", PostalCode = "92660", RegistrationId = "FBIS02938KBT", RegistrationDate = new DateTime(2017, 6, 13), SuperheroStatusId = 3 },
                  new Superhero { Id = 11, SuperheroName = "Dumpster Fire", FirstName = "Jimmy", LastName = "Richardson", Phone = "4324590914", Email = "Jimardson@gmail.com", Abilities = "Causes decomposing materials to combust whenever he wins Rock, Paper, Scissors.", Notes = "Has a history of accidental arson. \nSpent 7 months on the FBI's Most Wanted list for starting a fire on an airplane midflight.", DateOfBirth = new DateTime(1992, 1, 2), AgencyId = 3, StreetAddress = "1091 Sandwich Rd.", City = "Eugene", State = "Oregon", PostalCode = "97408", RegistrationId = "SBPD83947UWT", RegistrationDate = new DateTime(2014, 3, 20), SuperheroStatusId = 2 },
                  new Superhero { Id = 12, SuperheroName = "", FirstName = "Levi", LastName = "Ivel", Phone = "7289283341", Email = "racecarracecar@gmail.com", Abilities = "Finger scissors are actual working scissors.", Notes = "Cause of death was due to him unintentionally severing his cable while bungee jumping.", DateOfBirth = new DateTime(1992, 6, 10), AgencyId = 4, StreetAddress = "222 Skyview Ave.", City = "Denver", State = "Colorado", PostalCode = "80204", RegistrationId = "GFHI92GG7P0", RegistrationDate = new DateTime(2014, 3, 20), SuperheroStatusId = 4 },
                  new Superhero { Id = 13, SuperheroName = "pH Taster", FirstName = "Tony", LastName = "Dunn", Phone = "7355520755", Email = "pHoShizzle@gmail.com", Abilities = "Can taste the pH level of substances.", Notes = "Cause of death was poisoning due to ingesting a multitude of toxic chemicals while testing their pH level.  No foul play suspected.", DateOfBirth = new DateTime(1986, 5, 29), AgencyId = 5, StreetAddress = "92038 Substrate St.", City = "Denver", State = "Colorado", PostalCode = "80210", RegistrationId = "HELP73834ME7", RegistrationDate = new DateTime(2006, 7, 2), SuperheroStatusId = 4 }
                );

            //Dependents=========================================================================
            //builder.Entity<Dependent>().HasData(
            //    new Dependent { Id = 1, FirstName = "Joe", LastName = "Schmoe", Phone = "2839285930", Email = "Joe1@gmail.com", DateOfBirth = new DateTime(1990, 2, 2), RelationshipToSuperhero = "Sibling", StreetAddress = "202 Vanilla Ct.", City = "Seattle", StateOrProvince = "Washington", Country = "USA", PostalCode = "98116", }
            //    );

           base.OnModelCreating(builder);
        }//end of OnModelCreating

    }//end of class
}//end of namespace