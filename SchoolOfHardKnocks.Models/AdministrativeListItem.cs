using SchoolOfHardKnocks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Models
{
    public class AdministrativeListItem : SchoolName
    {
        public Guid AdminId { get; set; }
        public string Title { get; set; }
    }
}
