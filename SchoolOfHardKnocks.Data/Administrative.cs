
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Data
{   
    public class Administrative : SchoolName
    {
        [Key]
        public Guid AdminId { get; set; }
       
        public string Title { get; set; }
    }
}
