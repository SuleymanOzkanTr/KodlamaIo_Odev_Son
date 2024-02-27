using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities1.Concretes
{
    public class Courses
    {

        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }

        public bool StatusFree { get; set; }

        public decimal Progressrate
        {
            get
            {
                return Progressrate;
            }
            set
            {
                value = 0;
            }
        }

        
    }
}
