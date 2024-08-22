﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment03EF.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int Dep_Id { get; set; }

        public Department Department { get; set; }
        public ICollection<Stud_Course> StudCourses { get; set; }
    }


}
