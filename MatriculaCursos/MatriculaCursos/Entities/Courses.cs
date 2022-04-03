using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaCursos
{
    internal class Courses
    {
        static HashSet<Student> students = new HashSet<Student>();

        public static void AddStudent(Student s)
        {
            students.Add(s);
        }

    }
}
