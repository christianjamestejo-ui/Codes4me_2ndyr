using OOPSamplesStudent;
using OOPSamplesTeacher;
using System.Reflection.Emit;

namespace OOPSamplesMain
{
    class Program
    {



        static void Main(string[] args)
        {
            //Constructor
            Student _student = new Student(2, "Alexandra", "Soriano");

           

            Teacher _teacher = new Teacher();
            _teacher.Id = 1;
            _teacher.FirstName = "Mark";
            _teacher.LastName = "Amioda";

            _student.DisplayStudent();

        }
    }
}


