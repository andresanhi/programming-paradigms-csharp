using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncionalProgramming
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = CreateStudents();
            Console.WriteLine(students.Any(x => x.Name == "Juana"));
        }

        static List<Student> CreateStudents()
        {
            return new List<Student>
            {
                new Student
                {
                   Name = "Pepito", 
                   LastName = "Pèrez",
                   Age = 12
                },
                new Student
                {
                   Name = "Roberto",
                   LastName = "Gómez",
                   Age = 34
                },
                new Student
                {
                   Name = "Juana",
                   LastName = "De Arco",
                   Age = 18
                }
            };
        }
    }
}
