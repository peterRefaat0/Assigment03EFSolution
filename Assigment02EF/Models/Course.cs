﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment03EF.Models
{
    public class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_ID { get; set; }

        public Topic Topic { get; set; }
        public ICollection<Stud_Course> StudCourses { get; set; }
        public ICollection<Course_Inst> CourseInstructors { get; set; }
    }
}
