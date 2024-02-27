using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Instructors:Courses
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }
}
