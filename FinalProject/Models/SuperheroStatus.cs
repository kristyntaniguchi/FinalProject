using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class SuperheroStatus
    {
        //Lookup Table
        //Properties
        //Id===================================================
        [Key]
        public int Id { get; set; }

        //StatusTitle==========================================
        //Active, inactive, retired, in-training, deceased.
        [Required]
        [StringLength(50)]
        public string StatusTitle { get; set; }


        //Navigation Properties
        //Superhero============================================================
        //One to many - A Superhero can have one status, a status can belong to many heroes.
        //To see a list of superheroes based on their status
        public IEnumerable<Superhero> Superheroes { get; set; }
    }
}
