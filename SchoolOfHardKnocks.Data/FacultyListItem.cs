﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Data
{
    public class FacultyListItem: SchoolName
    {
        public int FacultyId { get; set; }  
        public string Dept { get; set; }
        
    }
}
