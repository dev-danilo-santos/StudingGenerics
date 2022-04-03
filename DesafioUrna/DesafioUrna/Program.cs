using System;
using System.IO;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();


            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vs = sr.ReadLine().Split(",");
                        string cantidato = vs[0];
                        int votos = int.Parse(vs[1]);

                        if (dic.ContainsKey(cantidato))
                        {
                            dic[cantidato] += votos;
                        }
                        else
                        {
                            dic[cantidato] = votos;
                        }

                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (var item in dic)
            {
                Console.WriteLine(item.Key+": "+item.Value+ "votes.");
            }

        }
    }
}