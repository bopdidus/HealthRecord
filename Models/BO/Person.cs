using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthRecord.Models.BO
{
    public enum GenderType
    {
        MALE,
        FEMALE
    }
    public abstract class Person
    {
        [StringLength(80)]
        public string FirstName { get; set; }
        //[RegularExpression(".+@.+\\..+", ErrorMessageResourceType = typeof(ViewResources.Resources.),
        //                            ErrorMessageResourceName = "EmailInvalid")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")]
        public string Email { get; set; }
       // [StringLength(80)]
        //[Required(ErrorMessage = "The lastname is required")]
        public string LastName { get; set; }

        //[RegularExpression(@"^[0-9]{9}$")]
        //[Required(ErrorMessage = "The Phone number is required and contains only the number")]
        public string PhoneNumber { get; set; }
        //[Required]
        public DateTime DateBirth { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string NumCNI { get; set; }
        public string Marital { get; set; }
        public Address Address { get; set; }
        public GenderType Gender { get; set; }

    }
}
