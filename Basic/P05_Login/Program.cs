namespace P05_Login
{
    using System;
    public class Program
    {
        static void Main()
        {
            
            string user = Console.ReadLine();
            string password = string.Empty;
            for (int i = user.Length - 1; i >= 0; i--)
            {
                password += user[i];
            }
            var inputPassword = String.Empty;
            var count = 0;
            while (inputPassword!=password)
            {
                if (count == 4)
                {

                    Console.WriteLine($"User {user} blocked!");
                    return;
                }
                count++;
                inputPassword = Console.ReadLine();
                if (inputPassword!=password&&count<4)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else if(inputPassword==password)
                {
                    Console.WriteLine($"User {user} logged in.");
                    return;
                }
               
            }
        }
    }
}