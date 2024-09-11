using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrapdemo.Models
{
    public class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
        public DateTime BirthDt { get; set; }
    }
}