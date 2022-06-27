using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class DataProcessing
    {
        public ICollection<IEducationalInstitution> Institutions { get; }
        public University University { get; internal set; }
        // var university = new University("Igor Sikorsky Polytechnic Institute");
        public void SetUniversityData()
        {
            var University = new University("Igor Sikorsky Polytechnic Institute");
            var universityStudent = new UniversityStudent[]
            {
            new UniversityStudent
            {
                  FirstName = "Rebecca",
                  LastName = "Harris",
                  MiddleName = "Vyacheslavivna",
                  FullSemestr = 3,
                  MethodOfStudying = MethodOfStudying.Daily,
                  Marks = new Marks(new Dictionary<string, double>
                  {
                      {"Software engenering", 100 },
                      {"Comp Networks", 90 },
                      {"Analys of Data", 99 }

                  })
            },
            new UniversityStudent
            {
                  FirstName = "Andrey",
                  LastName = "Taylor",
                  MiddleName = "Andreyovich",
                  FullSemestr = 3,
                  MethodOfStudying = MethodOfStudying.Evening,
                  Marks = new Marks(new Dictionary<string, double>
                  {
                      {"Software engenering", 90 },
                      {"Comp Networks", 70 },
                      {"Analys of Data", 70 }

                  })
            },
            };
            foreach(var item in universityStudent)
            {
                University.AddStudents(item);
            }
        }        
    }
}
