using System;

namespace pass
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = string.Empty;


            for (int i = user.Length - 1; i >= 0; i--)
            {
                pass += user[i];
            }

            int tries = 0;

            while (true)
            {
                string currentUser = Console.ReadLine();

                if (currentUser != pass)
                {
                    tries++;

                    if (tries == 4)
                    {
                        Console.WriteLine($"User {user} blocked!");
                        break;
                    }

                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }
            }
        
        }
    }
}

