using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment03EF.Models
{
    public class Course_Inst
    {
        public int inst_ID { get; set; }
        public int Course_ID { get; set; }
        public string evaluate { get; set; }

        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
