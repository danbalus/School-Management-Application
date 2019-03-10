using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Catalog.Models
{
    public class Student
    {
        [Key]//, ForeignKey("ApplicationUser")]
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Seed { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        //public virtual RegisterViewModel RegisterViewModel { get; set; }


      
      // public string ApplicationUser_Id { get; set; }
       // [ForeignKey("ApplicationUser")]
        public virtual ApplicationUser ApplicationUser { get; set; }
        //[ForeignKey("ApplicationUser")]
        //public string ApplicationUser_Id { get; internal set; }
    }
}