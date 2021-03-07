using Fei.BaseLib;
using System;
using System.Text;

namespace Delegat
{
    class Delegat
    {
        private static Students _students;
        static private void PrintMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("1. Add student\n");
            sb.Append("2. Show students\n");
            sb.Append("3. Sort by number\n");
            sb.Append("4. Sort by name\n");
            sb.Append("5. Sort by faculty\n");
            sb.Append("0. Exit\n");

            Console.WriteLine(sb.ToString());
        }

        static void Main(string[] args)
        {
            _students = new Students(1);
            while(true) {
                PrintMenu();
                try
                {
                    int selected = Reading.ReadInt("Menu item");
                    switch (selected)
                    {
                        case 1:
                            AddStudent();
                            break;
                        case 2:
                            ShowStudents();
                            break;
                        case 3:
                            SortStudents("Number");
                            break;
                        case 4:
                            SortStudents("Name");
                            break;
                        case 5:
                            SortStudents("Faculty");
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Wrong input");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private static bool CompareByNumber(Student first, Student second)
        {
            return first.number > second.number;
        }

        private static bool CompareByName(Student first, Student second)
        {
            return string.CompareOrdinal(first.name, second.name) > 0;
        }

        private static bool CompareByFaculty(Student first, Student second)
        {
            return string.CompareOrdinal(first.faculty.ToString(), second.faculty.ToString()) > 0;
        }

        private static void SortStudents(string sortBy)
        {
            if(sortBy == "Number")
            {
                _students.Sort(CompareByNumber);
            } else if(sortBy == "Name")
            {
                _students.Sort(CompareByName);
            } else if(sortBy == "Faculty")
            {
                _students.Sort(CompareByFaculty);
            }
        }

        private static void ShowStudents()
        {
            for(int i = 0; i < _students.countOfStudents; i++)
            {
                Console.WriteLine(_students[i].ToString());
            }
        }

        private static void AddStudent()
        {
            String name = Reading.ReadString("Name");
            int number = Reading.ReadInt("Number");
            String faculty = Reading.ReadString("Faculty");
            Student student = new Student(name, number, (Student.Faculty)Enum.Parse(typeof(Student.Faculty), faculty));
            _students.Append(student);
        }
    }
}
