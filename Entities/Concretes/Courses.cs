﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }

        public bool Status { get; set; }

        public decimal Progressrate { get; set; }
    }
}
