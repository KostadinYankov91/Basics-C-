using System;
using System.Linq;

namespace Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstTupleData = Console.ReadLine().Split();
            string fullName = $"{firstTupleData[0]} {firstTupleData[1]}";
            string address = firstTupleData[2];
            string town = firstTupleData[3];

            if (firstTupleData.Length > 4)
            {
                town = $"{firstTupleData[firstTupleData.Length - 2]} {firstTupleData.Last()}"; 
            }

            Threeuple<string, string, string> firstTuple = new Threeuple<string, string, string>(fullName, address, town);

            string[] secondTupleData = Console.ReadLine().Split();
            string name = secondTupleData[0];
            string beerLiters = secondTupleData[1];
            //bool state = secondTupleData[2] == "drunk" ? true : false;
            bool state = secondTupleData[2] == "drunk";

            //if (state == "drunk")
            //{
            //    state = "True";
            //}
            //else
            //{
            //    state = "False";
            //}

            Threeuple<string, int, bool> secondTuple = new Threeuple<string, int, bool>(name, int.Parse(beerLiters), state);

            string[] thirdTupleData = Console.ReadLine().Split();
            string nameTwo = thirdTupleData[0];
            string accountbalance = thirdTupleData[1];
            string bankName = thirdTupleData[2];

            Threeuple<string, double, string> thirdTuple = new Threeuple<string, double, string>(nameTwo, double.Parse(accountbalance), bankName);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
