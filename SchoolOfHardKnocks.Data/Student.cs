using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Data
{
    public enum Grade { FR = 1, SO, JR, SR }
    public class Student : SchoolName
    {
        [Key]
        public Guid StudentId { get; set; }
        [Required]
        public Grade GradeLevel { get; set; }
        //
        //
    }
    
}
