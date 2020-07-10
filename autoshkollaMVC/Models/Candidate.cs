using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace autoshkollaMVC.Models
{
    public class Candidate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
            
    }
}
