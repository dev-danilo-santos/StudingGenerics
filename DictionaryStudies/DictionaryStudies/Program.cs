namespace course
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();

            map["user"] = "maria";
            map["email"] = "@maria";
            map["phone"] = "123123";
            map["phone"] = "343243";

            Console.WriteLine(map["phone"]);

            Console.WriteLine("size"+map.Count);

            foreach (var item in map)
            {
                Console.WriteLine(item.Key +" " + item.Value);
            }

        }
    }
}