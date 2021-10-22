using System;

namespace greaterThanTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            var result = GetMax(type, first, second);

            Console.WriteLine(result);
        }

       

        private static string GetMax(string type,
                                     string first, 
                                     string second)
        {
            var result1 = 0;
            var result2 = 0;

            if (type == "int")
            {
               result1 = int.Parse(first);
               result2 = int.Parse(second);
            }

            else if (type == "char")
            {
                result1 = char.Parse(first);
                result2 = char.Parse(second);
            }

            else if (type == "string")
            {
                int comparison = first.CompareTo(second);

                if (comparison > 0)
                {
                    return first;
                }
                else
                {
                    return second;
                }
            }
            if (result1 > result2)
            {
                return first;
            }
            else
            {
                return second;
            }

        }
    }
}
