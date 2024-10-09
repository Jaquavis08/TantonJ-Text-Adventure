namespace Text_Adventure
{
    internal class Program
    {       
        static void WriteLetterByLetter(string text)
        {
            for (int i = 0; i < text.Length; ++i)
            {
                Console.Write(text[i]);
                Thread.Sleep(20);
            } 

            Console.WriteLine();     
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title =("Gone Hiking");
            Console.WriteLine("Jaquavis Studios Presents");
            Thread.Sleep(3000);
            Console.WriteLine("Gone Hiking");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteLetterByLetter("Type 'start' To Start");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(">");
            string input = Console.ReadLine();
            if (input == "start")
            { 
                Console.ForegroundColor = ConsoleColor.Red;
                WriteLetterByLetter("BANG! BANG! BANG! DING! DONG! DING! DONG! BANG! BANG! BANG!");
                Thread.Sleep(1000);
                WriteLetterByLetter("DUDE GET UP! ITS TIME TO GO! WERE GOING TO BE LATE!");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine("get up  |  stay in bed");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.Write(">");
            string input2 = Console.ReadLine();
            if (input2 == "get up")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                WriteLetterByLetter("Okay, okay, I'm getting up");
                Thread.Sleep(500);
                WriteLetterByLetter("Just let me get my bag");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("grab bag  |---------"); // if the bag is grabed keep going with the story 
                // if the player goes down stairs the player gets to go back up or open the door
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (input2 == "stay in bed")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                WriteLetterByLetter("You got a blood cloat in your brain becuse you were inactive for too long");
                Console.WriteLine();
                Thread.Sleep(1500);
                Console.WriteLine("GAME OVER");
                Console.WriteLine();
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Press Any Key To Restart");
            }

            Console.Write(">");
            string input3 = Console.ReadLine();
            if (input3 == "grab bag")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                WriteLetterByLetter("Okay I should be good to go");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("go down stairs  |  stay");
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.Write(">");
            string input4 = Console.ReadLine();
            if (input4 == "go down stairs")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                WriteLetterByLetter("I need to clean up down here");
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("grab bearspray  |  go to basement");
            }
            else if (input4 == "stay")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Hmmmm");
                WriteLetterByLetter("HEY GUYS NEVER MIND I'M NOT GOING");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("----------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                WriteLetterByLetter("WHAT THE HECK! WE'VE BEEN PLANING THIS FOR AGES");
                WriteLetterByLetter("YOU KNOW WHAT WE DON'T NEED YOU ANYWAYS");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("----------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You Died of Loneliness Because You No Longer Have Friends");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(">");
            string input5 = Console.ReadLine();
            if (input5 == "bearspray")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                WriteLetterByLetter("I'll stow this just in case");
                Thread.Sleep(1500);
                WriteLetterByLetter("I guess my only option is to open the door");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("open door  |--------");
            }
            else if (input5 == "go to basement")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You forgot you have a cripling fear of the dark, so you quickly run back up");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("open door  |--------");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(">");
            string input6 = Console.ReadLine();
            if (input6 == "open door")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                WriteLetterByLetter("Finally, what took you so long.");
                Thread.Sleep(1000);
                WriteLetterByLetter("You know what never mind. We have to go, Like NOW.");
            }



            Console.ReadKey();
            
        }        
    }
}
