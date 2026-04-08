using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolAppCoreRazor.Models
{ 
    public class Student
    {
        public int StudentID { get; set; }
        public required string LastName
        {
            get; set;
        }
        public required string FirstName
        {
            get; set;
        }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment>? Enrollments
        { get; set; }
    }
}