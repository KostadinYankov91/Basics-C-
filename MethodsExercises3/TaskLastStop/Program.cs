using System;
using System.Collections.Generic;
using System.Linq;

namespace lastStop
{
    class Program
    {

        public static List<string> Numbers = new List<string>();

        static void Main(string[] args)
        {
            Numbers = Console.ReadLine().Split().ToList();

            string paintingOne, paintingTwo;
            int place, painting;
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] arguments = input.Split();
                string command = arguments[0];

                switch (command)
                {
                    case "Change":
                        paintingOne = arguments[1];
                        paintingTwo = arguments[2];
                        Change(paintingOne, paintingTwo);
                        break;
                    case "Hide":
                        paintingOne = arguments[1];
                        Hide(paintingOne);
                        break;
                    case "Switch":
                        paintingOne = arguments[1];
                        paintingTwo = arguments[2];
                        Swtich(paintingOne, paintingTwo);
                        break;
                    case "Insert":
                        place = int.Parse(arguments[1]);
                        painting = int.Parse(arguments[2]);
                        InsertPainting(place, painting);
                        break;
                    case "Reverse":
                        ReverseOrder();
                        break;
                    default:
                        break;
                }
            }

            Numbers.ForEach(p => Console.Write($"{p} "));

        }

        public static void Change(string one, string two)
        {
            int indexOne = Numbers.IndexOf(one);

            if (Numbers.Contains(one))
            {
                Numbers[indexOne] = two;
            }

            return;
        }

        public static void Hide(string one)
        {
            if (Numbers.Contains(one))
            {
                Numbers.Remove(one);
            }

            return;
        }

        public static void Swtich(string one, string two)
        {
            int indexOne = Numbers.IndexOf(one);
            int indexTwo = Numbers.IndexOf(two);
            string temp = string.Empty;

            if (Numbers.Contains(one) && Numbers.Contains(two))
            {
                temp = Numbers[indexOne];
                Numbers[indexOne] = Numbers[indexTwo];
                Numbers[indexTwo] = temp;
            }

            return;
        }

        public static void InsertPainting(int one, int two)
        {
            if (Numbers.Count > one + 1 && one + 1 > -1)
            {
                Numbers.Insert(one + 1, two.ToString());
            }

            return;
        }

        public static void ReverseOrder()
        {
            Numbers.Reverse();
            return;
        }
    }
}
