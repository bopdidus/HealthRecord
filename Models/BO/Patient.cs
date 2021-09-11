using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthRecord.Models.BO
{
    
    public class Patient:Person
    {
        public bool Status { get; set; } = true;
        public long Code { get; set; }
        public string Allergy { get; set; }
        public int Id { get; set; }
        public DateTime Birthdate { get; set; }
        
    }
}
