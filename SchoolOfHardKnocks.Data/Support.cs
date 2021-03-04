using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Data
{   
    public class Support : SchoolName
    {
        public Guid SupportId { get; set; }
       
        public string Role { get; set; }
    }
}
