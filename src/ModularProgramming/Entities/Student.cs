using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularProgramming.Entities
{
    public  class Student
    {
        public Student()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Score = 0;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public double Score { get; set; }
    }
}
