using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace FinalProject.Models
{
    public class Relationship
    {
        //Bridge Table
        //Properties
        //Id===================================================
        [Key]
        public int Id { get; set; }

        //RelationshipStatus===================================================
        public string RelationshipToSuperhero { get; set; }


        //Foreign Keys
        //SuperheroId==========================================
        public int SuperheroId { get; set; }

        //DependentId==========================================
        public int DependentId { get; set; }


        //Navigation Properties
        //Superhero============================================================
        //One to many - A Superhero can have one status, a status can belong to many heroes.
        public Superhero Superhero { get; set; }

        //Dependent============================================================
        public Dependent Dependent { get; set; }


    }
}
