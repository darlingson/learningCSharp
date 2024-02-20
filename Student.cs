using System;

namespace learningCSharp
{
    public class Student
    {
        public string Name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa)
        {
            Name = aName;
            this.major = aMajor;
            this.gpa = aGpa;
        }

        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            else
            {
               return false;
            }
        }
    }
}