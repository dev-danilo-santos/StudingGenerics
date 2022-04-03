using System.Collections.Generic;
namespace hashSet
{
    class TesteProgram
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("Tv");
            set.Add("Notebook");
            set.Add("Tablet");

            //Console.WriteLine(set.Contains("Noteb"));

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

        }
    }
}