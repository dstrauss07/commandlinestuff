using System;
using System.Collections.Generic;
using System.Text;

namespace CommandLineApp
{
    class Marathon
    {
        private static void Main(string[] args)
        {
            int Score = 0;
            Console.WriteLine("You are running in a marathon tomorrow");

            Start:
            Console.WriteLine("Get a good Night sleep? Or Stay up Late worrying?");
            Console.WriteLine("Type SLEEP or WORRY");
            string input1 = Console.ReadLine();
            string upperInput1 = input1.ToUpper();
            if(upperInput1 == "SLEEP")
            {
                Console.WriteLine("you sleep well and wake up refreshed the next morning");
                Score++;
                goto Race;
          
            }
            if (upperInput1 == "WORRY")
            {
                Console.WriteLine("you worry all night and don't sleep at all");
                goto Race;
            }
            else
            {
                Console.WriteLine("Invalid Choice");
                goto Start;
            }

        Race:
            Console.WriteLine("Will you Run as Fast as you can, or take it slow and steady.");
            Console.WriteLine("Type FAST or SLOW");
            string input2 = Console.ReadLine();
            string upperInput2 = input2.ToUpper();
            if (upperInput2 == "FAST")
            {
                Console.WriteLine("you run super fast, but you're soon out of breath");
                goto Middle;

            }
            if (upperInput2 == "SLOW")
            {
                Console.WriteLine("you find your rythym and soon pass by the silly sprinters");
                Score++;
                goto Middle;
            }
            else
            {
                Console.WriteLine("Invalid Choice");
                goto Race;
            }

            Middle:
            Console.WriteLine("10 miles to go!  Man are you tired, do you stop for water or Push on to the end?");
            Console.WriteLine("Type WATER or PUSH");
            string input3 = Console.ReadLine();
            string upperInput3 = input3.ToUpper();
            if (upperInput3 == "WATER")
            {
                Console.WriteLine("you drink cool cool water, hydration is key!");
                Score++;
                goto Finish;

            }
            if (upperInput3 == "PUSH")
            {
                Console.WriteLine("Water is for chumps, oh god, cramps CRAMPS!");
                goto Finish;
            }
            else
            {
                Console.WriteLine("Invalid Choice");
                goto Middle;
            }

            Finish:
            if (Score == 3)
            {
                Console.WriteLine("WHAT A RACE!  You finish first, and set an all time world record. DAMN SON");
            }
            if (Score == 2)
            {
                Console.WriteLine("You did okay, but it wasn't your best.  Keep training and maybe next time champ.");
            }
            if (Score == 1)
            {
                Console.WriteLine("Well that was embarassing.  Maybe running marathons isn't really for you after all. Lets go have a beer");
            }
            if (Score == 0)
            {
                Console.WriteLine("You limp to the finish line. no one is there, they all left hours ago. SAD.");
            }



            Console.ReadLine();

        }
       

    }
}
