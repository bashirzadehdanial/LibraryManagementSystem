using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        private int nextId = 1;

        public void AddBook(string title, string author)
        {
            books.Add(new Book { Id = nextId++, Title = title, Author = author });
            Console.WriteLine($"Book '{title}' by {author} added with ID {nextId - 1}.");
        }

        public void ListBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void CheckoutBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            if (book.IsCheckedOut)
            {
                Console.WriteLine("Book is already checked out.");
            }
            else
            {
                book.IsCheckedOut = true;
                Console.WriteLine($"You have checked out '{book.Title}' by {book.Author}.");
            }
        }

        public void ReturnBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            if (!book.IsCheckedOut)
            {
                Console.WriteLine("Book is already returned.");
            }
            else
            {
                book.IsCheckedOut = false;
                Console.WriteLine($"You have returned '{book.Title}' by {book.Author}.");
            }
        }
    }
}
