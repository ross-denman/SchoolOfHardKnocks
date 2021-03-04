using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Data
{
    public enum Grade { FR = 1, SO, JR, SR }
    public class Student
    {
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Grade Grade { get; set; }
        //
        //
    }
}
