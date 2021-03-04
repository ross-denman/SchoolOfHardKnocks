
using SchoolOfHardKnocks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Models
{
    // public enum Grade { FR = 1, SO, JR, SR }
    public class StudentListItem: SchoolName
    {
        public Guid StudentId { get; set; }
        public Grade GradeLevel { get; set; }
    }
    
}
