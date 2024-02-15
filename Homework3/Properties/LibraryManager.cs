using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework3.books;

namespace Homework3.LibraryManagers
{
    public static class LibraryManager
    {
        public static List<Book> books = new List<Book>();
        public static void add(Book book)
        {

            books.Add(book);
        }
        public static void remove(string title)
        {
            Book bookToRemove = books.Find(book => book.GetTitle() == title);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("Book removed successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
        public static void display()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"Title: {book.GetTitle()}, Author: {book.GetAuthor().GetName()}, Category: {book.GetCategory().GetCategoryName()}, Year: {book.GetYear()}, Price: {book.GetPrice()}");
            }
        }

    }
}
