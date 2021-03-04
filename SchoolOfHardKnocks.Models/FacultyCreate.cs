using SchoolOfHardKnocks.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Models
{
    public class FacultyCreate : SchoolName
    {
        [Key]
        public int FacultyID { get; set; }
        [Required]
        public string Dept { get; set; }

    }
}
