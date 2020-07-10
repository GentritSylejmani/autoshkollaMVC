using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace autoshkollaMVC.Models
{
    public enum Category
    {
        A1,A,B1,B,C1,D1,D,BE,C1E,CE,D1E,DE,M,L,T
    }
    public class Course
    {
        public int ID { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public int Hours { get; set; }
        public double PricePerHour { get; set; }

    }
}
