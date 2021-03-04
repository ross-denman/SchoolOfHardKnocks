using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Data
{
    public class Faculty
    {
        [Key]
        public Guid FacultyId { get; set; }
        public int FacultyID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Dept { get; set; }
    }
}
