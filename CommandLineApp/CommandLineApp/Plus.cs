using System;

namespace CommandLineApp
{
    class Plus
    {
        static void Main(string[] args)
        {
            string input1;
            string input2;
            int intVal1;
            int intVal2;
            int sumVal;

            Console.WriteLine("Enter First Number to Add");
            input1 = Console.ReadLine();
            intVal1 = Convert.ToInt32(input1);
            Console.WriteLine("you entered '{0}'", intVal1);
            Console.WriteLine("Enter Second Number to Add");
            input2 = Console.ReadLine();
            intVal2 = Convert.ToInt32(input2);
            Console.WriteLine("you entered '{0}'", intVal2);
            sumVal = intVal1 + intVal2;
            Console.WriteLine("{0} + {1} = {2}", intVal1, intVal2, sumVal);
            Console.ReadLine();
        }
    }
}
