using HashCodeAndContains.Entities;

namespace course
{
    class ProgramTest
    {
        static void Main(string[] args)
        {
            HashSet<Product> set = new HashSet<Product>();

            Product p1 = new Product("Tv",1000);
            Product p2 = new Product("Tv",1000);

            set.Add(p1);
            set.Add(p2);
            
            Product p3 = new Product("Tv",1000);
            Console.WriteLine(set.Contains(p3));
            Console.WriteLine(set.Count());
        }
    }
}