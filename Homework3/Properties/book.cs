using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework3.Authors;
using Homework3.Categories;
namespace Homework3.books
{
    public class Book
    {
        private string title;
        private Author author;
        private Category category;
        private int year;
        private double price;



        public Book(string title, Author author, Category category, int year, double price)
        {
            this.title = title;
            this.author = author;
            this.category = category;
            this.year = year;
            this.price = price;
        }

        public string GetTitle() { return title; }
        public void SetTitle(string title) { this.title = title; }

        public Author GetAuthor() { return author; }
        public void SetAuthor(Author author) { this.author = author; }

        public Category GetCategory() { return category; }
        public void SetCategory(Category category) { this.category = category; }

        public int GetYear() { return year; }
        public void SetYear(int year) { this.year = year; }

        public double GetPrice() { return price; }
        public void SetPrice(double price) { this.price = price; }

    }
}
