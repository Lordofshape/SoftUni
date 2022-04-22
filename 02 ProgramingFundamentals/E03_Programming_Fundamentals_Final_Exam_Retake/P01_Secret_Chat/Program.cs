namespace P01_Secret_Chat
{
    using System.Linq;
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArgs = input.Split(":|:");
                string cmd = cmdArgs[0];
                if (cmd == "InsertSpace")
                {
                    int index = int.Parse(cmdArgs[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (cmd == "Reverse")
                {
                    string subString = cmdArgs[1];
                    if (message.Contains(subString))
                    {
                        int startIndex = message.IndexOf(subString);
                        message = message.Remove(startIndex, subString.Length);
                        subString = string.Join("", subString.Reverse());
                        message += subString;
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    string substring = cmdArgs[1];
                    string replacment = cmdArgs[2];
                    message = message.Replace(substring, replacment);
                    Console.WriteLine(message);
                }
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
