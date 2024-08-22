using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment03EF.Models
{
    public class Stud_Course
    {
        public int stud_ID { get; set; }
        public int Course_ID { get; set; }
        public string Grade { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
