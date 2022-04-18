using System;
using System.Linq;

namespace P03_Ladybugs
{
    internal class Program
    {
        static void Main()
        {
           /* int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] ladyBugsIndexs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < field.Length; i++)
            {
                    if (ladyBugsIndexs.Contains(i))
                    {
                        field[i] = 1;
                    }
            }
            string input;
            while ((input=Console.ReadLine())!="end")
            {
                string[] commands=input.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                int index = int.Parse(commands[0]);
                string direction=commands[1];
                int length=int.Parse(commands[2]);

                if (index < 0 || index >= field.Length)
                {
                   
                    continue;
                }

                //We have valid index, then we check if there is a ladybug
                //If there isn't a ladybug
                if (field[index] == 0)
                {
                    continue;
                }
                field[index] = 0;

                //Calculate where the next index is
                int nextIndex = index;
                while (true)
                {
                    if (direction == "right")
                    {
                        nextIndex += length;
                    }
                    else if (direction == "left")
                    {
                        nextIndex -= length;
                    }

                    if (nextIndex < 0 || nextIndex >= field.Length)
                    {
                        break;
                    }

                    if (field[nextIndex] == 0)
                    {
                        break;
                    }
                }

                if (nextIndex >= 0 && nextIndex < field.Length)
                {
                    field[nextIndex] = 1;
                }
            }

            Console.WriteLine(String.Join(" ", field));
*/

        }
        
    }
}
