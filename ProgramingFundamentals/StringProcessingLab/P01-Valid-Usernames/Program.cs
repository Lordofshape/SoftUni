using System;
using System.Text;


namespace P01_Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string input = Console.ReadLine();
          StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i + 1 >= input.Length)
                {
                    break;
                }

                while (input[i]==input[i+1])
                {
                    input = input.Remove(i + 1, 1);
                    if (i + 1 >= input.Length)
                    {
                        break;
                    }
                }
                

                
            }
            Console.WriteLine(input);


        }
       
        
    }
}
