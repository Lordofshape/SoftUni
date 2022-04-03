using System;

namespace P01_StringManipulator
{
    internal class Program
    {
        
/* "{char} {replacement}"
	" {substring}"
	" {substring}"

	" {char}"
	" {startIndex} {count}"*/

        static void Main(string[] args)
        {
            var manipulatingString = Console.ReadLine();
            string input;
            while ((input=Console.ReadLine())!="End")
            {
                string[] commandAndArgs = input.Split();
                string command = commandAndArgs[0];
                if (command =="Translate")
                {
                    string oldChar   = commandAndArgs[1];
                    string newChar = commandAndArgs[2];
                    manipulatingString = manipulatingString.Replace(oldChar,newChar);
                    Console.WriteLine(manipulatingString);
                }
                else if (command == "Includes")
                {
                    string checkString = commandAndArgs[1];
                    bool IsInclude = manipulatingString.Contains(checkString);
                    Console.WriteLine(IsInclude);
                }
                else if (command == "Start")
                {
                    string IsStartString = commandAndArgs[1];
                    bool IsTrue = true;
                    for (int i = 0; i < IsStartString.Length; i++)
                    {
                        char originalChar = manipulatingString[i];
                        char checkChar = IsStartString[i];
                        if (originalChar!=checkChar)
                        {
                            IsTrue = false;
                        }
                    }
                    Console.WriteLine(IsTrue);
                }
                else if (command == "Lowercase")
                {
                    manipulatingString = manipulatingString.ToLower();
                    Console.WriteLine(manipulatingString);
                }
                else if (command == "FindIndex")
                {
                    int index = manipulatingString.LastIndexOf(commandAndArgs[1]);
                    Console.WriteLine(index);
                }
                else if (command == "Remove")
                {
                    int startIndexRemove = int.Parse(commandAndArgs[1]);
                    int countRemove = int.Parse(commandAndArgs[2]);
                    manipulatingString = manipulatingString.Remove(startIndexRemove, countRemove);
                    Console.WriteLine(manipulatingString);
                }
            }
        }
    }
}
