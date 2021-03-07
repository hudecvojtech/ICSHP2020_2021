using System;
using System.Collections.Generic;
using System.Text;

namespace Delegat
{
    class Student
    {
        public enum Faculty { FES, FF, FEI, FCHT }
        public string name { get; set; }
        public int number { get; set; }
        public Faculty faculty { get; set; }

        public Student(string name, int number, Faculty faculty)
        {
            this.name = name;
            this.number = number;
            this.faculty = faculty;
        }

        public override string ToString()
        {
            return "Number: " + number + " Name: " + name + " Faculty: " + faculty;
        }
    }
}
