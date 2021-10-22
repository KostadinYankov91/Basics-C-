using System;
using System.Collections.Generic;
using System.Linq;

namespace truckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int gasStations = int.Parse(Console.ReadLine());
            Queue<string> gasStationsData = new Queue<string>();

            for (int i = 0; i < gasStations; i++)
            {
                gasStationsData.Enqueue(Console.ReadLine());
            }


            for (int i = 0; i < gasStations; i++)
            {
                int currGasAmount = 0;
                bool isSuccessfull = true;

                for (int j = 0; j < gasStations; j++)
                {
                    //gasStationsData.Enqueue(string.Join(" ", gasData));

                    string gasDataStr = gasStationsData.Dequeue();
                    int[] gasData = gasDataStr.Split().Select(int.Parse).ToArray();
                    gasStationsData.Enqueue(gasDataStr);

                    currGasAmount += gasData[0];
                    
                    currGasAmount -= gasData[1];

                    if (currGasAmount < 0)
                    {
                        isSuccessfull = false;
                    }
                }

                if (isSuccessfull)
                {
                    Console.WriteLine(i);
                    break;
                }

                string tempdata = gasStationsData.Dequeue();
                gasStationsData.Enqueue(tempdata);

            }



        }
    }
}
