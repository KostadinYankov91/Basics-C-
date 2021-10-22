using System;

namespace arrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr1 = Console.ReadLine()
                                   .Split(" ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string elementToRotate = arr1[0];

                for (int j = 1; j < arr1.Length; j++)
                {
                    string currentElement = arr1[j];
                    arr1[j - 1] = currentElement;
                }

                arr1[arr1.Length - 1] = elementToRotate;
            }

            Console.WriteLine(string.Join(" ", arr1));
        }
    }
}
