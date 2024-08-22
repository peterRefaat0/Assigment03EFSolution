using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment03EF.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }
        public decimal Bonus { get; set; }
        public int Dept_ID { get; set; }

        public ICollection<Department> Departments { get; set; }

        public ICollection<Course_Inst> CourseInstructors { get; set; }
    }
}
