using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthRecord.Models.BO
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Quater { get; set; }

        public Address()
        {
        }


       /* public override string ToString()
        {
            return $"{this.Street} {this.HouseNumber}, {this.PostalCode} {this.State}-{this.Country}";
        }*/
    }
}
