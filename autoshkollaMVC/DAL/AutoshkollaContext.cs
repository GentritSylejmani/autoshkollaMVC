using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using autoshkollaMVC.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.EntityFrameworkCore;

namespace autoshkollaMVC.DAL
{
    public class AutoshkollaContext: DbContext
    {
        public AutoshkollaContext(DbContextOptions<AutoshkollaContext> options) : base(options)
        {

        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
