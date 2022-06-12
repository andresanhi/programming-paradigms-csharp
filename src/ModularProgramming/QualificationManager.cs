using ModularProgramming.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularProgramming
{
    public class QualificationManager
    {
        public List<Student> Students { get; set; }
        public bool AddQualification(int score, string id)
        {
            var student = Students.FirstOrDefault(x => x.Id == id);
            student.Score = score;
            return true;
        }

        public bool AddStudent(string name, string lastName)
        {
            Student newStudent = new();
            newStudent.Name = name;
            newStudent.LastName = lastName;
            Students.Add(newStudent);
            return true;
        }

        public Student GetStudent(string name, string lastName)
        {
            return Students.FirstOrDefault(x => x.Name == name && x.LastName == lastName);
        }
    }
}
