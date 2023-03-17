using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FinalProject.Models
{
    public class Dependent
    {
        //Properties
        //Id==================================================
        public int Id { get; set; }

        //FirstName===========================================
        [Required(ErrorMessage = "Required field")]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        //LastName============================================
        [Required(ErrorMessage = "Required field")]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //DateOfBirth============================================
        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        //Photo================================================================
        //Store the photo somewhere else, on a webserver usually, then put the location of the image in the database string
        [StringLength(100)]
        public string Photo { get; set; }

        //Notes=================================================
        public string Notes { get; set; }

        //Phone================================================================
        //For children without their own phone, enter a parent/guardian's phone number.
        [Phone]
        [Required(ErrorMessage = "Required field")]
        public string Phone { get; set; }

        //Email================================================================
        //Not required because children might not have emails.
        [EmailAddress]
        public string Email { get; set; }

        //Address==============================================================
        [Required(ErrorMessage = "Required field")]
        [StringLength(80)]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "Required field")]
        [StringLength(58)]
        //Llanfair¬pwllgwyngyll¬gogery¬chwyrn¬drobwll¬llan¬tysilio¬gogo¬goch in Wales is 58 characters long and, not including the full ceremonial name for Bangkok which is 160+ characters, is the longest city name in the world.
        public string City { get; set; }

        //Not all countries have States or Provinces and a postal code help identify cities with the same name.
        [StringLength(50)]
        [Display(Name = "State or Province")]
        public string StateOrProvince { get; set; }

        [Required(ErrorMessage = "Required field")]
        [StringLength(56)]
        //The United Kingdom Of Great Britain And Northern Ireland
        public string Country { get; set; }

        [Required(ErrorMessage = "Required field")]
        [StringLength(20)]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }


        //Navigation Properties
        //Relationships==========================================================
        //One to many - A Dependent can have many relationships, a relationship can only have one Dependent
        public IEnumerable<Relationship> Relationships { get; set; }
    }
}
