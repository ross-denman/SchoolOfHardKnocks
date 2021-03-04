
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Data
{   
    public class Administrative : SchoolName
    {
        public Guid AdminId { get; set; }
       
        public string Title { get; set; }
    }
}
