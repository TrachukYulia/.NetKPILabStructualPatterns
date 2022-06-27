using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
   public class School: IEducationalInstitution
    {
        private List<IStudent> _listOfStudents = new List<IStudent>();
        public string Name { get; private set; }
        public List<IStudent> ListOfStudents => _listOfStudents;
        public School(string name)
        {
            Name = name;
        }
        public void AddStudents(IStudent student)
        {
            _listOfStudents.Add(student);
        }
    }
}
