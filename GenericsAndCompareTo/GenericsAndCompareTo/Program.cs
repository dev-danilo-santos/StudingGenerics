using GenericsAndCompareTo.Entities;
using GenericsAndCompareTo.Services;
namespace GenericsAndCompareTo
{
   class TestProgram
    {
        static void Main(string[] args)
        {   
            List<Product> products = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the produc {i+1}: ");
                string[] list = Console.ReadLine().Split(',');
                products.Add(new Product(list[0], double.Parse(list[1])));
            }
            CalculationService cs = new CalculationService();
            Console.Write("Max: "+ cs.Max(products));
        }
    }
}