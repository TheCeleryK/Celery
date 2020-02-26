using System;

namespace European_Council_Voting_Calculator
{
    class Calculator
    {
        public static void Main(string[] args)
        {

            int voteYes;
            float Population;
            int Check1 = 0;
            int Check2 = 0;


            Console.Write("How many countries voted For? ");
            voteYes = int.Parse(Console.ReadLine());
            if (voteYes > 15)
            { Check1 = Check1 + 1; }

            Console.Write("What percentage of the population? ");
            Population = int.Parse(Console.ReadLine());
            if (Population > 64.99)
            { Check2 = Check2 + 1; }

            if (Check1 + Check2 == 2)
            { Console.WriteLine("Passed!"); }
            else
                Console.WriteLine("Denied!"); 

        }
    }
}
