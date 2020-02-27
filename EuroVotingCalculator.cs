using System;

namespace European_Council_Voting_Calculator
{
    //All is encapsulated within this Class
    class Calculator
    {
        public static void Main(string[] args)
        {
            //Called upon later in the code.
            int voteYes;
            float Population;
            int voteCheck = 0;
            int popCheck = 0;

            //Data is adstracted from country names to numbers.
            Console.Write("How many countries voted For? ");
            voteYes = int.Parse(Console.ReadLine());
            if (voteYes > 14)
            { voteCheck = voteCheck + 1; }

            Console.Write("What percentage of the population? ");
            Population = int.Parse(Console.ReadLine());
            if (Population > 64.99)
            { popCheck = popCheck + 1; }

            if (voteCheck + popCheck == 2)
            { Console.WriteLine("Passed!"); }
            else
                Console.WriteLine("Denied!"); 

        }
    }
}
