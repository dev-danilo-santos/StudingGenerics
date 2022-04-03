using EqualsAndHashCode.Entitites;
namespace equalsAndHashCode
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Client c1 = new Client("Dener Santos", "706160121 97",18);
            Client c2 = new Client("Danilo Santos", "705.150.921-77",23);

            //Console.WriteLine(c1.ToString());
            //Console.WriteLine(c2.ToString());
            //Console.WriteLine(c1.Equals(c2));
            //Console.WriteLine(c1.GetHashCode());
            //Console.WriteLine(c2.GetHashCode());

            Console.WriteLine(c1.Older(c2).ToString());

        }
    }
}