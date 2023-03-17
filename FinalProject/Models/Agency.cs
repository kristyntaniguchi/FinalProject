using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace FinalProject.Models
{
    public class Agency
    {
        //Properties
        //Id==================================================
        public int Id { get; set; }

        //Name================================================
        [Required(ErrorMessage = "Required field")]
        [StringLength(50)]
        [Display(Name = "Agency Name")]
        public string Name { get; set; }

        //HeadquartersAddress=============================================
        [Required(ErrorMessage = "Required field")]
        [StringLength(80)]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "Required field")]
        [StringLength(58)]
        public string City { get; set; }

        [StringLength(50)]
        [Display(Name = "State or Province")]
        public string StateOrProvince { get; set; }

        [Required(ErrorMessage = "Required field")]
        [StringLength(56)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Required field")]
        [StringLength(20)]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        //Insignia================================================================
        //Store the photo somewhere else, on a webserver usually, then put the location of the image in the database string
        [StringLength(100)]
        public string Insignia { get; set; }


        //Navigation Properties
        //Superhero============================================================
        //One to many - A superhero can have one agency, an agency can have many superheroes
        public IEnumerable<Superhero> Superhero { get; set; }



    }
}
