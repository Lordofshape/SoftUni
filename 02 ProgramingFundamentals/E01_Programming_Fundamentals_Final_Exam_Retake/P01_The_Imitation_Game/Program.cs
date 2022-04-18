using System;

namespace P01_The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string enctyption = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] commandArgs = input.Split('|');
                string command = commandArgs[0];
                if (command == "Move")
                {
                    int lettersNum = int.Parse(commandArgs[1]);
                    string lettersToMove = enctyption.Substring(0, lettersNum);
                    enctyption = enctyption.Remove(0, lettersNum);
                    enctyption = enctyption + lettersToMove;
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(commandArgs[1]);
                    string value = commandArgs[2];
                    enctyption = enctyption.Insert(index, value);
                }
                else if (command == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacment = commandArgs[2];
                    enctyption = enctyption.Replace(substring, replacment);
                }
            }
            Console.WriteLine($"The decrypted message is: {enctyption}");
        }
    }
}
