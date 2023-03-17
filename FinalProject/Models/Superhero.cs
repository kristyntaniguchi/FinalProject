using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FinalProject.Models
{
    public class Superhero
    {
        //Properties
        //Id==================================================
        [Key]
        public int Id { get; set; }

        //SuperheroName=======================================
        [Required]
        [StringLength(50)]
        [Display(Name = "Superhero Name")]
        public string SuperheroName { get; set; }

        //FirstName===========================================
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        //LastName============================================
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //Abilities============================================
        [Required]
        public string Abilities { get; set; }

        //Notes=================================================
        public string Notes { get; set; }

        //DateOfBirth============================================
        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        //RegistrationDate=======================================
        [Required]
        [Display(Name = "Registration Date")]
        public DateTime RegistrationDate { get; set; }

        //RegistrationId=========================================
        [Required]
        [StringLength(15)]
        [Display(Name = "Registration ID")]
        public string RegistrationId { get; set; }

        //Photo================================================================
        //Store the photo somewhere else, on a webserver usually, then put the location of the image in the database string
        [StringLength(100)]
        public string Photo { get; set; }

        //Phone================================================================
        [Phone]
        [Required]
        public string Phone { get; set; }

        //Email================================================================
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        //Address==============================================================
        [Required]
        [StringLength(80)]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }


        //Foreign Keys************************************************************
        //AgencyId================================================================
        public int AgencyId { get; set; }

        //Lookup Table
        //SuperheroStatusId=======================================================
        public int SuperheroStatusId { get; set; }


        //Navigation Properties***************************************************
        //AgencyId================================================================
        //One to many - A superhero can have one agency, an agency can have many superheroes
        public Agency Agency { get; set; }

        //Relationships==========================================================
        //One to many - One superhero can have many relationships, a relationship can only have one superhero
        public IEnumerable<Relationship> Relationships { get; set; }

    }//end of class
}//end of namespace
