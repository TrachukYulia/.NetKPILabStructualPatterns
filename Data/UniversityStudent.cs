using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class UniversityStudent : IStudent
    {
        public UniversityStudent()
        {
            MaxSemestr = 8;
            Marks.MaxMarks = 100;
            Marks.MinMarks = 60;
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