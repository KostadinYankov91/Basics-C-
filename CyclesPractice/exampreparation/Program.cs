using System;
using System.Diagnostics.Tracing;
using System.Linq;

namespace exampreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                             .Split(" ")
                             .Select(int.Parse)
                             .ToArray();
            int counter = 0;

            string input = Console.ReadLine();

            while (input?.ToUpper() != "END")
            {
                int index = int.Parse(input);

                if (index < 0 || index >= sequence.Length || sequence[index] == -1)
                {
                    input = Console.ReadLine();
                    continue;
                }

                int shotTarget = sequence[index];
                sequence[index] = -1;
                counter++;

                for (int i = 0; i < sequence.Length; i++)
                {
                    if (sequence[i] == -1)
                    {
                        continue;
                    }
                    if (sequence[i] > shotTarget)
                    {
                        sequence[i] -= shotTarget;
                    }
                    else
                    {
                        sequence[i] += shotTarget;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {counter} -> {string.Join(' ', sequence)}");

        }

       //public static int SequenceOperations(int[] sequence, int shotTarget)
       //{
       //    for (int i = 0; i < sequence.Length; i++)
       //    {
       //        int index = int.Parse(Console.ReadLine());
       //
       //        if (index == sequence[i])
       //        {
       //            sequence[i] = -1;
       //
       //            foreach (int target in sequence)
       //            {
       //
       //            }
       //        }
       //        else if (index >= sequence.Length)
       //        {
       //            continue;
       //        }
       //        
       //    }
       //
       //    return
       //}
    
    }
}
