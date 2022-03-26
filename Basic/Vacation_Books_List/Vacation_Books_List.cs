using System;

namespace Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input from console
            int bookList = int.Parse(Console.ReadLine());
            int listsForOneHour = int.Parse(Console.ReadLine());
            //Logic
            int daysForBook = int.Parse(Console.ReadLine());
            int timeBook = bookList / listsForOneHour;
            int dayTimeForBook = timeBook / daysForBook;
            //Output from console
            Console.WriteLine(dayTimeForBook);
        }
    }
}
