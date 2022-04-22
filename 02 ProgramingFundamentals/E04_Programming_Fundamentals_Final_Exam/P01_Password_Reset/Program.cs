namespace P01_Password_Reset
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();

            string input;
            while ((input=Console.ReadLine())!= "Done")
            {
                string[] cmdArgs = input.Split();
                string cmd = cmdArgs[0];
                if (cmd == "TakeOdd")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i < password.Length; i+=2)
                    {
                        sb.Append(password[i]);
                    }
                    password = sb.ToString();
                    Console.WriteLine(password);
                }
                else if (cmd == "Cut")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int length = int.Parse(cmdArgs[2]);
                    password = password.Remove(index,length);
                    Console.WriteLine(password);
                }
                else
                {
                    string substring = cmdArgs[1];
                    string substitute = cmdArgs[2];
                    if (!password.Contains(substring))
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                    else
                    {
                        password = password.Replace(substring,substitute);
                        Console.WriteLine(password);
                    }
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
