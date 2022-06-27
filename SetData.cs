using EducationData.EducationalInstitution;
using System;
using System.Collections.Generic;
using System.Text;
using EducationData;
namespace StructualPatterns
{
    public class SetData
    {
        public List<IEducationalInstitution> Institutions { get; }
       
        public SetData()
        {
            Institutions = new List<IEducationalInstitution>();
        }
        public void SetUniversityData()
        {
            var university = new EducationalInstitution<UniversityStudent>("Igor Sikorsky Polytechnic Institute");
            var universityStudent = new UniversityStudent[]
            {
            new UniversityStudent
            {
                  FirstName = "Rebecca",
                  LastName = "Harris",
                  MiddleName = "Vyacheslavivna",
                  FullSemestr = 7,
                  MethodOfStudying = MethodOfStudying.Daily,
                  Mark = new Marks(new Dictionary<string, double>
                  {
                      {"Software engenering", 100 },
                      {"Comp Networks", 90 },
                      {"Analys of Data", 99 }

                  })
            },
            new UniversityStudent
            {
                  FirstName = "Adam",
                  LastName = "Taylor",
                  MiddleName = "Andreyovich",
                  FullSemestr = 8,
                  MethodOfStudying = MethodOfStudying.Evening,
                  Mark = new Marks(new Dictionary<string, double>
                  {
                      {"Software engenering", 90 },
                      {"Comp Networks", 70 },
                      {"Analys of Data", 70 }

                  })
            },
             new UniversityStudent
            {
                  FirstName = "Zara",
                  LastName = "Marshall",
                  MiddleName = "Bridges",
                  FullSemestr = 4,
                  MethodOfStudying = MethodOfStudying.Evening,
                  Mark = new Marks(new Dictionary<string, double>
                  {
                      {"Software engenering", 50 },
                      {"Comp Networks", 70 },
                      {"Analys of Data", 70 }

                  })
            },
            };
            foreach(var item in universityStudent)
            {
                university.AddStudents(item);
            }
           Institutions.Add(university);
        }
        
        public void SetSchoolData()
        {
            var school = new EducationalInstitution<SchoolStudent>("Kyiv secondary school №10");

            var schoolStudent = new SchoolStudent[]
            {
            new SchoolStudent
            {
                  FirstName = "Robert",
                  LastName = "Edwards",
                  MiddleName = "Vasylovych",
                  FullSemestr = 20,
                  MethodOfStudying = MethodOfStudying.Evening,
                  Mark = new Marks(new Dictionary<string, double>
                  {
                      {"Math", 11 },
                      {"Ukrainian language", 10 },
                      {"Biology", 11 }

                  })
            },
            new SchoolStudent
            {
                  FirstName = "Jordan",
                  LastName = "Rivera",
                  MiddleName = "Hernandez",
                  FullSemestr = 22,
                  MethodOfStudying = MethodOfStudying.Individual,
                  Mark = new Marks(new Dictionary<string, double>
                  {
                      {"Math", 10 },
                      {"Ukrainian language", 12 },
                      {"Chemistry", 6 }
                  })
            },
             new SchoolStudent
            {
                  FirstName = "Jerry ",
                  LastName = "Castillo",
                  MiddleName = "Whitney",
                  FullSemestr = 18,
                  MethodOfStudying = MethodOfStudying.Individual,
                  Mark = new Marks(new Dictionary<string, double>
                  {
                      {"Math", 10 },
                      {"Ukrainian language", 12 },
                      {"Physics", 2 }
                  })
            },
            };
            foreach (var item in schoolStudent)
            {
                school.AddStudents(item);
            }
           Institutions.Add(school);
        }
    }
}
