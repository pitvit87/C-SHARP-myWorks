using System;
using System.Reflection;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;


namespace ConsoleApp1
{
    class ExamEventArgs : EventArgs
    {
        public string Task { get; set; }
    }
    class Student
    {
        public string firstName;
        public string lastName;


        public Student (string _firstName, string _lastName)
        {
            firstName = _firstName;
            lastName = _lastName;   
        }

    
        public void Exam(object sender, ExamEventArgs e)
        {
            WriteLine("Student: {0} - {1} => {2}", lastName, firstName, e.Task);
        }
    
    }

    class Teacher
    {
        public EventHandler<ExamEventArgs> ExamEvent;

        public void Exam(ExamEventArgs task)
        {
            if (ExamEvent != null)
            {
                ExamEvent(this, task);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> st = new List<Student>();

            st.Add(new Student("John", "Johnson"));
            st.Add(new Student("Michael", "Michellsson"));
            st.Add(new Student("Jack", "Nickolson"));

            Teacher tc = new Teacher();

            foreach (Student s in st)
                tc.ExamEvent += s.Exam;

            ExamEventArgs examArgs = new ExamEventArgs();
            examArgs.Task = "Task";

            tc.Exam(examArgs);

            ReadLine();
        }
    }
}
