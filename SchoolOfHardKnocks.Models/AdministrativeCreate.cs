using SchoolOfHardKnocks.Data;
using SchoolOfHardKnocks.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Services
{
    public class AdministrativeCreate : SchoolName
    {
        [Key]
        public Guid AdminID { get; set; }
        [Required]
        public string Title { get; set; }

    }
}
