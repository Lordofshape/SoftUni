namespace T01_Old_Books
{
using System;

    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();

            string book = Console.ReadLine();

            int checkedBooks = 0;

            while (book!= "No More Books")
            {
                if (book==favoriteBook)
                {
                    Console.WriteLine($"You checked {checkedBooks} books and found it.");
                    break;
                }
                checkedBooks++;
                book = Console.ReadLine();
            }
            if (book== "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
            }
        }
    }
}
