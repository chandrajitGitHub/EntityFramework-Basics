﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFWManyToManyRelationship
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public IList<Course> Courses { get; set; }
    }
}