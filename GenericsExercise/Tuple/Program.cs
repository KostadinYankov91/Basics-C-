using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstTupleData = Console.ReadLine().Split();
            string fullName = $"{firstTupleData[0]} {firstTupleData[1]}";
            MyTuple<string, string> firstTuple = new MyTuple<string, string>(fullName, firstTupleData[2]);
            string[] secondTupleData = Console.ReadLine().Split();
            
            MyTuple<string, int> secondTuple = new MyTuple<string, int>(secondTupleData[0], int.Parse(secondTupleData[1]));
            string[] thirdTupleData = Console.ReadLine().Split();
            MyTuple<string, double> thirdTuple = new MyTuple<string, double>(thirdTupleData[0], double.Parse(thirdTupleData[1]));

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
            

            //Tuple<int, double, string> tuple = new Tuple<int, double, string>(10, 5.5, "Peter");

            //(int, double) t = (10, 5.6); //tuple implementation

            //Console.WriteLine(t2.name);
            //(int num, string name) t2 = (20, "Georgi");
            //Console.WriteLine(t2.num);

            //Console.WriteLine(tuple.Item1);
            //Console.WriteLine(tuple.Item2);

            
        }
    }
}
