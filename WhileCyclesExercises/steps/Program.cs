using System;

namespace steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            int totalSteps = 0;
            int target = 10000;

            while (totalSteps < target)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    steps = int.Parse(Console.ReadLine());
                    totalSteps += steps;
                    break;
                }
                else
                {
                    steps = int.Parse(input);
                    totalSteps += steps;
                }
            }

            if (totalSteps >= target)
            {
                Console.WriteLine($"Goal reached! Good job!\n " +
                    $"{Math.Abs(totalSteps - target)} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(totalSteps - target)} more steps to reach goal.");
            }
        }
    }
}
