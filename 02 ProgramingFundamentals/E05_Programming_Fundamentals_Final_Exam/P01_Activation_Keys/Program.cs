namespace P01_Activation_Keys
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();
            string input;
            while ((input=Console.ReadLine())!= "Generate")
            {
                string[] cmdArgs = input.Split(">>>");
                string cmd = cmdArgs[0];
                if (cmd == "Contains")
                {
                    string substring = cmdArgs[1];
                    if (rawActivationKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if(cmd == "Flip")
                {
                    string charCase = cmdArgs[1];
                    int startIndex = int.Parse(cmdArgs[2]);
                    int endIndex = int.Parse(cmdArgs[3]);
                    string flip = rawActivationKey.Substring(startIndex, endIndex - startIndex);
                    string newFlip;
                    if (charCase=="Upper")
                    {
                        newFlip = flip.ToUpper();
                        rawActivationKey = rawActivationKey.Replace(flip, newFlip);
                    }
                    else
                    {
                        newFlip = flip.ToLower();
                        rawActivationKey = rawActivationKey.Replace(flip, newFlip);
                    }      
                    Console.WriteLine(rawActivationKey);
                }
                else
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(rawActivationKey);
                }
            }
            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
