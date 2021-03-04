using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Data
{   
    public class Support : SchoolName
    {
        [Key]
        public Guid SupportId { get; set; }
       
        public string Role { get; set; }
    }
}
