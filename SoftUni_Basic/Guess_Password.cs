namespace Guess_Password
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string enterpasword = Console.ReadLine();
            string password = "s3cr3t!P@ssw0rd";
            if (password==enterpasword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
