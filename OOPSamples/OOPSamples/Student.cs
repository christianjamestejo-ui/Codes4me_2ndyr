using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSamplesStudent
{
    public class Student
    {
        //private readonly DbContext _dbContext;

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        //Constructor
        public Student(/*DbContext dbContext,*/ int _id, string? _firstname, string? _lastname)
        {
            //_dbContext = dbContext;
            Id = _id;
            FirstName = _firstname;
            LastName = _lastname;
        }

        //Method
        //public void UpdateStudentFirstName(string firstName) 
        //{
        //    FirstName = firstName;
        //}

        //public void UpdateStudentLastName(string lastName) 
        //{
        //    LastName = lastName;
        //}

        public void DisplayStudent() 
        {
            //String Interpolation
            Console.WriteLine($"\nId: {Id}" +
                $"\nFirst Name: {FirstName}" +
                $"\nLast Name: {LastName}");
        }

    }
}
