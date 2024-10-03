namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jaquavis Studios Presents");
            Console.WriteLine("Gone Hiking");
            Console.WriteLine("Type Start To Start");

            string input = Console.ReadLine();
            if (input == "Start")
            {
                Console.WriteLine("(BANG!BANG!BANG!DING!DONG!DING!DONG!BANG!BANG!BANG!)");
                Console.WriteLine("DUDE GET UP! ITS TIME TO GO! WERE GOING TO BE LATE");
            }

            Console.ReadKey();
        }
    }
}
