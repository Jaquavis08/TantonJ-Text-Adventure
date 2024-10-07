namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title =("Gone Hiking");
            Console.WriteLine("Jaquavis Studios Presents");
            Console.WriteLine("Gone Hiking");
            Console.WriteLine("Type 'start' To Start");

            string input = Console.ReadLine();
            if (input == "start")
            { 
                Console.WriteLine("(BANG!BANG!BANG!DING!DONG!DING!DONG!BANG!BANG!BANG!)");
                Console.WriteLine("DUDE GET UP! ITS TIME TO GO! WERE GOING TO BE LATE!");
                Console.WriteLine("get up  |  stay in bed");
            }
            

            string input2 = Console.ReadLine();
            if (input2 == "get up")
            {
                Console.WriteLine("Okay okay I'm getting up");
                Console.WriteLine("just let me get my bag");
                Console.WriteLine("grab bag  |  go down stairs"); // if the bag is grabed keep going with the story 
                // if the player goes down stairs the player gets to go back up or open the door
            }
            else if (input2 == "stay in bed")
            {
                Console.WriteLine("You got a blood cloat in your brain becuse you were inactive for too long");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("Press Any Key To Restart");
            }


            string input3 = Console.ReadLine();
            if (input3 == "grab bag")
            {
                Console.WriteLine("Okay I should be good to go");
                Console.WriteLine("go down stairs  |  stay");
            }
            else if (input3 == "go down stairs")
            {
                Console.WriteLine("grab gun  |  go to the basement");
            }

            Console.ReadKey();
            
        }        
    }
}
