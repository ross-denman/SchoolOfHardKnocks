
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Data
{
    public class Faculty : SchoolName
    {
        public Guid FacultyId { get; set; }

        public string Dept { get; set; }
    }
}
