using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();

            int counter = 0;
            var found = false;

            string nextBook = Console.ReadLine();
            while (nextBook != "No More Books")
            {
                if (nextBook == favBook)
                {
                    found = true;
                    break;
                }
                counter++;
                nextBook = Console.ReadLine();
            }
            if (found)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here! ");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
