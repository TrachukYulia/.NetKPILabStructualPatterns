using System;
using EducationData;
using System.Linq;
namespace StructualPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SetData data = new SetData();
                data.SetUniversityData();
                data.SetSchoolData();
                foreach (var item in data.Institutions)
                    ShowStudentInfo(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        static void ShowStudentInfo(IEducationalInstitution data)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(data.Name);
            Console.WriteLine();

            foreach (var item in data.ListOfStudents)
            {
                Console.Write("Fullname: {0} {1} {2}\nType of studying: {3}\nAmount of Semestr: {4}\nAmount of courses: {5} \n", 
                    item.FirstName, item.LastName, item.MiddleName, item.MethodOfStudying, item.FullSemestr, data.CourseOfStudent(item));
                foreach (var mark in item.Mark.MarksOfStudent)
                    Console.WriteLine("Subject: {0}, Mark {1}", mark.Key, mark.Value);
                Console.WriteLine(data.WayToContinueStudying(item));
                Console.WriteLine();
            }
        }
    }
}
