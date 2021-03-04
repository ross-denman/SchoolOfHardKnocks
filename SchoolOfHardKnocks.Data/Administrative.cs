using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Data
{   
    public class Administrative
    {

        [Key]
        public Guid AdminId { get; set; }
        public int AdminID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }

        // Use for Principal. VP etc.
    }
}
