using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StudentClass.Models
{
    class Student
    {
        private string firstName;
        private string middle;
        private string lastName;
        private int permanentAddress;
        private string socialSecurityNumber;  //Student Social Security Number (SSN. E.g. "000-00-0000" 
        private string facultyNumber;  //Student faculty number
        private string course;
        private string specialty;
        private string mobilePhone;
        private string email;
        private string university;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Middle
        {
            get { return middle; }
            set { middle = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int PermanentAddress
        {
            get { return permanentAddress; }
            set { permanentAddress = value; }
        }

        public string SocialSecurityNumber
        {
            get { return socialSecurityNumber; }
            set { socialSecurityNumber = value; }
        }

        public string FacultyNumber  //Student faculty number
        {
            get { return facultyNumber; }
            set { facultyNumber = value; }
        }

        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }

        public string MobilePhone
        {
            get { return mobilePhone; }
            set { mobilePhone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string University
        {
            get { return university; }
            set { university = value; }
        }
    }
}

//More about Student Social Security Number (SSN) --> https://www.ssa.gov/pubs/EN-05-10181.pdf