using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HealthRecord.Models.ViewModels
{
    public class PatientViewModel
    {
        [Required(ErrorMessage = "Please enter your Firstname")] 
        [Display(Name = "Firstname", Prompt = "Enter First Name")]
        [MaxLength (25)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your Lastname")]
        [Display(Name = "Lastname", Prompt = "Enter Last Name")]
        [MaxLength(25)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter a correct Email Address")]
        [Display(Name = "Email", Prompt = "Enter Email Address")]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter a correct Phone Number")]
        [Display(Name = "Phonenumber", Prompt = "Enter a phone number")]
        [MaxLength(25)]
        [Phone]
        public string PhoneNumber { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd:mm:yyyy}")]
        [Required(ErrorMessage = "Please enter a Date of Birth")]
        [Display(Name = "birthdate", Prompt = "Enter a birth  date")]
        public DateTime Birthdate { get; set; }
        [Required(ErrorMessage = "Please enter a correct Phone Number")]
        [Display(Name = "country", Prompt = "Select the country")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Please enter a correct Phone Number")]
        [Display(Name = "town", Prompt = "Enter a town")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter a correct Phone Number")]
        [Display(Name = "street", Prompt = "Enter a street name")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Please enter a correct House Number")]
        [Display(Name = "housenumber", Prompt = "Enter a house number")]
        public string Gender { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required]
        public string NumCNI { get; set; }
        [Required]
        public string Marital { get; set; }
        public string City { get; set; }
        public string Quater { get; set; }

    }
}
