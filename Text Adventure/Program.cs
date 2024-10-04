namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title =("one Hiking");

            Console.WriteLine("Jaquavis Studios Presents");
            Console.WriteLine("Gone Hiking");
            Console.WriteLine("Type Start To Start");

            string input = Console.ReadLine();
            if (input == "Start")
            {
                Console.WriteLine("(BANG!BANG!BANG!DING!DONG!DING!DONG!BANG!BANG!BANG!)");
                Console.WriteLine("DUDE GET UP! ITS TIME TO GO! WERE GOING TO BE LATE!");
                Console.WriteLine("Get Up  |  Stay In Bed");
            }

            string input2 = Console.ReadLine();
            if (input2 == "Get Up")
            {
                
            }
            else if (input2 == "Stay In Bed")
            {
                Console.WriteLine("You got a blood cloat in your brain becuse you were inactive for too long");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("Press Any Key To Restart");
            }
            
            Console.ReadKey();
            
        }
    }
}
