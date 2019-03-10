using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catalog.Models
{
 
    public class Professor
    {

        public int ProfessorID { set; get; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}