using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace autoshkollaMVC.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CandidateID { get; set; }
        public int InstructorID { get; set; }
        public int CourseID { get; set; }
        public DateTime RegisteredDate { get; set; }


        public virtual Candidate Candidate { get; set; }
        public virtual Course Course { get; set; }
        public virtual Instructor Instructor { get; set; }

    }
}
