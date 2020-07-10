using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace autoshkollaMVC.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime ActiveSince { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }


    }
}
