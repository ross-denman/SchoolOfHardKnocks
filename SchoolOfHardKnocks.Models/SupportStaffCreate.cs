using SchoolOfHardKnocks.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Models
{
    public class SupportStaffCreate : SchoolName
    {
        [Key]
        public Guid SupportId { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
