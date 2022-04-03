using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaCursos
{
    internal class Student
    {
        public int Id { get; set; }

        public Student(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return "Id "+Id;
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Student))
            {
                return false;
            }
            Student other = (Student)obj;
            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

    }
}
