using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework3.books;
using Homework3.Authors;
using Homework3.Categories;
using Homework3.LibraryManagers;
namespace Homework3
{

    public static class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Please input what do you want to do next");
                Console.WriteLine("write |1| to add a book");
                Console.WriteLine("write |2| to delete a book");
                Console.WriteLine("write |3| to show all the existing books");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {

                    switch (choice)
                    {
                        case 1:
                            AddBook();
                            break;
                        case 2:
                            RemoveBook();
                            break;
                        case 3:
                            ListAllBooks();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                            break;
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        static void AddBook()
        {
            Console.WriteLine("Enter book details:");
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Author Name: ");
            string authorName = Console.ReadLine();
            Console.Write("Author Biography: ");
            string biography = Console.ReadLine();
            Console.Write("Category: ");
            string categoryName = Console.ReadLine();
            Console.Write("Category Description: ");
            string categoryDescription = Console.ReadLine();
            Console.Write("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Author author = new Author(authorName, biography);
            Category category = new Category(categoryName, categoryDescription);
            Book book = new Book(title, author, category, year, price);

            LibraryManager.add(book);
            Console.WriteLine("Book added successfully.");
        }

        static void RemoveBook()
        {
            Console.Write("Enter the title of the book to remove: ");
            string title = Console.ReadLine();
            LibraryManager.remove(title);
        }

        static void ListAllBooks()
        {
            Console.WriteLine("List of all books:");
            LibraryManager.display();
        }
    }
   
 
   

   
}
