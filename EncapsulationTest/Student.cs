using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTestStudent
{
    public class Student
    {
        //Properties
        private Guid Id;
        private string FirstName;
        private string LastName;
        private DateTime Birthdate;

        //Constructor
        public Student(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthDate;
            Id = Guid.NewGuid();
        }

        //Method
        public string DisplayStudent()
        {
            string result = "";

            if (!validation(FirstName) || !validation(LastName)) 
            {
                result = "The name must not be empty!";
            }
            else
            {
                result = $"Student ID: {Id}\nFirst Name: {FirstName}\nLast Name: {LastName}\nBirthdate: {Birthdate.ToString("MM-dd-yyyy")}";
            }
                return result;
        }

        private bool validation(string inputString) 
        {
            return !string.IsNullOrEmpty(inputString);
        }
    }
}
