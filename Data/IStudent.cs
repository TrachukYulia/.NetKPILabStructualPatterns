using System;

namespace Data
{
    public interface IStudent
    {
         string FirstName { get;  set; }
         string LastName { get;  set; }
         string MiddleName { get;  set; }
         MethodOfStudying MethodOfStudying { get;  set; }
         Marks Marks { get;  set; }
         int FullSemestr { get;  set; }
         int MaxSemestr  {get;}
       // public int MinMarks { get; internal set; }

    }
}
