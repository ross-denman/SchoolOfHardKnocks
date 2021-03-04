using SchoolOfHardKnocks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Models
{
    public class SupportStaffListItem : SchoolName
    {
        public Guid SupportId { get; set; }
        public string Role { get; set; }
    }
}
