using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class SchoolStudent : IStudent
    {
        public SchoolStudent()
        {
            MaxSemestr = 24;
            

        }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public Marks Marks { get; set; } = new Marks();
        public int FullSemestr { get; set; }
        public int MaxSemestr { get; }
        public MethodOfStudying MethodOfStudying { get; set; }
    }
}
