using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._School_Library
{
    class Program
    {
        static void Main()
        {
            List<string> booksList = Console.ReadLine().Split("&").ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                string[] command = input.Split(" | ").ToArray();

                if (command[0] == "Add Book")
                {
                    string bookName = command[1];
                    if (!booksList.Contains(bookName))
                    {
                        booksList.Insert(0, bookName);
                    }
                }
                else if (command[0] == "Take Book")
                {
                    string bookName = command[1];
                    if (booksList.Contains(bookName))
                    {
                        booksList.Remove(bookName);
                    }
                }
                else if (command[0] == "Swap Books")
                {
                    string bookName1 = command[1];
                    string bookName2 = command[2];

                    if (booksList.Contains(bookName1) && booksList.Contains(bookName2))
                    {
                        int index1 = booksList.IndexOf(bookName1);
                        int index2 = booksList.IndexOf(bookName2);

                        booksList.Insert(index1, bookName2);
                        booksList.RemoveAt(index1 + 1);
                        booksList.Insert(index2, bookName1);
                        booksList.RemoveAt(index2 + 1);
                    }
                }
                else if (command[0] == "Insert Book")
                {
                    string bookName = command[1];
                    booksList.Add(bookName);
                }
                else if (command[0] == "Check Book")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < booksList.Count)
                    {
                        Console.WriteLine(booksList[index]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", booksList));
        }
    }
}
