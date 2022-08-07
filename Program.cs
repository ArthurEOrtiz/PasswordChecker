using System;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "%TGB5tgb";
            char[] passwordArray = new char[password.Length];

            for (int i = 0; i<password.Length; i++)
            {
                passwordArray[i] = password[i];
            }

            foreach (char c in passwordArray) {
                Console.WriteLine(c);
            }

            
        }
    }
}
