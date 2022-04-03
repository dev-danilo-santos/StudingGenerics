using MatriculaCursos;

namespace Couse
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> a = new HashSet<Student>();
            HashSet<Student> b = new HashSet<Student>();
            HashSet<Student> c = new HashSet<Student>();

            a.Add(new Student(21));
            a.Add(new Student(35));
            a.Add(new Student(22));

            b.Add(new Student(21));
            b.Add(new Student(50));

            c.Add(new Student(42));
            c.Add(new Student(35));
            c.Add(new Student(13));

            a.UnionWith(b);
            a.UnionWith(c);
            Console.WriteLine("Total Students: "+ a.Count);
        
        }
    }
}