
namespace Course
{
    class TestProgram
    {

        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 03, 04, 20, 04, 07);
            Console.WriteLine(dt.ElapsedTime());

            string s = "Good morning dear students!";
            Console.WriteLine(s.Cut(50));
        }
    }
}