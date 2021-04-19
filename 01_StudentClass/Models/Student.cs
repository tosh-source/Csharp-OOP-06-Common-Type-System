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
        private string middleName;
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

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
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

        public override string ToString()
        {
            var result = string.Empty;
            var newLine = Environment.NewLine;

            result += this.firstName + " " + this.MiddleName + " " + this.LastName + newLine;
            result += "PermanentAddress: " + this.PermanentAddress + newLine;
            result += "SocialSecurityNumber: " + this.SocialSecurityNumber + newLine;
            result += "FacultyNumber: " + this.FacultyNumber + newLine;
            result += "Course: " + this.Course + newLine;
            result += "Specialty: " + this.Specialty + newLine;
            result += "MobilePhone: " + this.MobilePhone + newLine;
            result += "Email: " + this.Email + newLine;
            result += "University: " + this.University + newLine;

            return result;
        }

        public override bool Equals(object obj)
        {
            var student = obj as Student;  //Using keyword "as" will try to cast object. If fail the object will be null. In this situation standard direct cast ((Student) obj) will throw an exception!

            if (student != null &&
               this.FirstName == student.FirstName &&
               this.MiddleName == student.MiddleName &&
               this.LastName == student.LastName &&
               this.PermanentAddress == student.PermanentAddress &&
               this.SocialSecurityNumber == student.SocialSecurityNumber &&
               this.FacultyNumber == student.FacultyNumber &&
               this.Course == student.Course &&
               this.Specialty == student.Specialty &&
               this.MobilePhone == student.MobilePhone &&
               this.Email == student.Email &&
               this.University == student.University)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            var hashCode = 1774673126;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MiddleName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + PermanentAddress.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SocialSecurityNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FacultyNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Course);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Specialty);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MobilePhone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(University);
            return hashCode;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }
        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !Student.Equals(firstStudent, secondStudent);
        }
    }
}

//More about override .Equals() and GetHashCode(), see video: "Обща система от типове в .NET (CTS) - 25 март 2015 - Ивайло" in time: |0:57:05 - 1:02:40|

//More about Student Social Security Number (SSN) --> https://www.ssa.gov/pubs/EN-05-10181.pdf