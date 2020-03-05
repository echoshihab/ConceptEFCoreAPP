using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConceptEFCoreAPP.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set;}
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //navigation property
        public ICollection<Enrollment> Enrollments { get; set;
        }
    }
}
