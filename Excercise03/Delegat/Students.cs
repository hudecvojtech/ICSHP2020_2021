using System;
using System.Collections.Generic;
using System.Text;

namespace Delegat
{
    class Students
    {
        private Student[] _students;
        public int countOfStudents { get; private set; }

        public Students(int countOfStudents)
        {
            _students = new Student[countOfStudents];
            this.countOfStudents = 0;
        }

        private void resize()
        {
            int newSize = countOfStudents == 0 ? 1 : countOfStudents * 2;
            Student[] newArray = new Student[newSize];
            for (int i = 0; i < _students.Length; i++)
            {
                newArray[i] = _students[i];
            }

            _students = newArray;

        }

        public void Append(Student student)
        {
            if (student == null) throw new ArgumentNullException("Input student is null.");

            if (countOfStudents >= _students.Length) resize();

            _students[countOfStudents++] = student;
        }

        public Student this[int index]
        {
            get
            {
                if (index < 0 || index >= countOfStudents)
                {
                    throw new ArgumentOutOfRangeException("Out of range.");
                }

                return _students[index];
            }

            set
            {
                if (index < 0 || index >= countOfStudents)
                {
                    throw new ArgumentOutOfRangeException("Out of range.");
                }

                _students[index] = value;
            }
        }

        public delegate bool Compare(Student first, Student second);

        public void Sort(Compare compare)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                for (int j = 0; j < _students.Length - 1; j++)
                {
                    if (compare(_students[j], _students[j + 1]))
                    {
                        Student temp = _students[j + 1];
                        _students[j + 1] = _students[j];
                        _students[j] = temp;
                    }
                }
            }
        }
    }
}
