using System.ComponentModel.Design;

namespace Text_Adventure
{
    internal class Program
    {
        static int age;

        /// <summary>
        /// writes text letter by letter
        /// </summary>
        /// <param name="text">the text to print</param>
        static void WriteLetterByLetter(string text)
        {
            for (int i = 0; i < text.Length; ++i)
            {
                Console.Write(text[i]);
                Thread.Sleep(15); // adjusts the speed at which the text is typed out
            }

            Console.WriteLine();
        }

        static void EndOfGame() //expo dump for the end of the game
        {
            // End of game
            Console.ForegroundColor = ConsoleColor.Green; // changes the color of the text from white to green
            Console.Write(">"); // indicates where the player can type
            string input6 = Console.ReadLine();
            if (input6 == "open door")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                WriteLetterByLetter("Finally, what took you so long.");
                Thread.Sleep(1000); // changes how long the player has to wait until the next line is displayed
                WriteLetterByLetter("You know what never mind, we have to go.");
                Thread.Sleep(3000);
                WriteLetterByLetter("What is that noise?");
                Thread.Sleep(1500);
                WriteLetterByLetter("BEAR!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                WriteLetterByLetter("Invalid response please try again");
                EndOfGame();
            }
        }

        static void SegmentFour() // expo dump for segment four
        {
            // Segment 4
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(">");
            string input5 = Console.ReadLine();
            if (input5 == "grab bear spray")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                WriteLetterByLetter("I'll stow this just in case");
                Thread.Sleep(1500);
                WriteLetterByLetter("I guess my only option is to open the door");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("open door  |--------");
            }
            else if (input5 == "go to basement")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("'You forgot you have a crippling fear of the dark, so you quickly run back up'"); 
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("open door  |--------");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                WriteLetterByLetter("Invalid response please try again");
                SegmentFour();
            }
        }

        static void SegmentThree() //expo dump for segment three
        {
            // Segment 3
            Console.Write(">");
            string input4 = Console.ReadLine();
            if (input4 == "go down stairs")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                WriteLetterByLetter("'I need to clean up down here'");
                Console.WriteLine();
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("grab bear-spray  |  go to basement");
            }
            else if (input4 == "stay")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Hmmmm");
                WriteLetterByLetter("HEY GUYS NEVER MIND I'M NOT GOING");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                WriteLetterByLetter("WHAT THE HECK! WE'VE BEEN PLANING THIS FOR AGES");
                WriteLetterByLetter("YOU KNOW WHAT WE DON'T NEED YOU ANYWAYS");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You Died of Loneliness Because You No Longer Have Friends");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                WriteLetterByLetter("Invalid response please try again");
                SegmentThree();
            }
        }

        static void SegmentTwo() // expo dump for segment two
        {
            // Segment 2
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(">");
            string input3 = Console.ReadLine();
            if (input3 == "grab bag")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                WriteLetterByLetter("Okay I should be good to go");
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("go down stairs  |  stay");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                WriteLetterByLetter("Invalid response please try again");
                SegmentTwo();
            }
        }

        static void SegmentOne() //expo dump for segment one
        {
            // Segment 1
            Console.ForegroundColor = ConsoleColor.Green;
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
                Console.WriteLine("grab bag  |---------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (input2 == "stay in bed")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                WriteLetterByLetter("You got a blood clout in your brain because you were inactive for too long");
                Console.WriteLine();
                Thread.Sleep(1500);
                Console.WriteLine("GAME OVER");
                Thread.Sleep(800);
                WriteLetterByLetter("type reset to reset");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                WriteLetterByLetter("Invalid response please try again");
                SegmentOne();
            }
        }

        static void ResetGame()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(">");
            string input6 = Console.ReadLine();
            if (input6 == "reset")
            {

            }
        }

        static void StartOfGame() //expo dump for the start of the game
        {
            // intro 2/start of game
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
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                WriteLetterByLetter("Invalid response please try again");
                StartOfGame();
            }
        }

        static void AskAge() //expo dump for the ask age stuffs
        {
            WriteLetterByLetter("Enter age here");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> "); // lets the player put in there age
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (age < 1*2+6*5+2/2+2)//change this
            {
                Console.ForegroundColor = ConsoleColor.Red;
                WriteLetterByLetter("sorry you are not old enough to play this game");
                AskAge();
            }
            if (age > 17)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Disclaimer This Game Contains Violence And People");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                WriteLetterByLetter("Invalid response please try again");
                AskAge();
            }
        }


        static void IntroToGame() //expo dump for the intro to the game
        {
            // intro to game
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = ("Gone Hiking Part 1");
            Console.WriteLine("Jaquavis Studios Presents");
            Thread.Sleep(3000);
            Console.WriteLine("Gone Hiking  Part 1");
            Console.WriteLine();
            Thread.Sleep(2000);
            AskAge();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteLetterByLetter("Type 'start' To Start");
            Console.WriteLine();

        }


        static void Main(string[] args)
        {
            // expo dump "outlet"
            IntroToGame();

            StartOfGame();

            SegmentOne();

            SegmentTwo();

            SegmentThree();

            SegmentFour();

            EndOfGame();




            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TO BE CONTINUED");

            // allows the player to see and read the console
            Console.ReadKey();

            
        }        
    }
}
