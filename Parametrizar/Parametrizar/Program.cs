using Parametrizar;
namespace Parametrizacao
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            PrintService<string> ps1 = new PrintService<string>();

            ps1.AddValue("João");
            ps1.AddValue("Maria");
            ps1.AddValue("Ana");

            ps1.First();
            ps1.Print();

            Console.WriteLine();
            PrintService<int> ps2 = new PrintService<int>();
            ps2.AddValue(1);
            ps2.AddValue(2);
            ps2.AddValue(3);

            ps2.First();
            ps2.Print();


        }
    }
}