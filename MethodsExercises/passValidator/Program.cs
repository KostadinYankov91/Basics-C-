using System;

namespace passValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isTrue = ValidateLength(password) &&
                          ValidateDigits(password) &&
                          ValidateTwoDigits(password);

            if (isTrue)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                
                if (!ValidateLength(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!ValidateDigits(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!ValidateTwoDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits\n" +
                                      "Password must have at least 2 digits\n" +
                                      "Password must be between 6 and 10 characters");
                }
            }
        }

        private static bool ValidateTwoDigits(string password)
        {
            int counter = 0;
            foreach (char item in password)
            {
                if (!char.IsDigit(item))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }

            return false;

        }

        private static bool ValidateDigits(string password)
        {
            foreach (char item in password)
            {
                if (!char.IsLetterOrDigit(item))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool ValidateLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                bool isTrue = true;
                return isTrue;
            }

            return false;
        }
    }
}
