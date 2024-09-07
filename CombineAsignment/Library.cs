using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Combine_Asignment
{
    public class Library

    {

        //3 Inventory Management Operations: Implement a `Library` class that manages a list of books (`List<Book>`).

        public List<Book> Books { get; set; }
        public Library()
        {
            Books = new List<Book>();
        }


        // Add a new book to the inventory

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        // Remove a book from the inventory by ID
        public void RemoveBookByID(int id)
        {
            var bookToRemove = Books.FirstOrDefault(b => b.ID == id);
            if (bookToRemove != null)
            {
                Books.Remove(bookToRemove);
                Console.WriteLine("Book ID: " + id + " has been removed.");
            }
            else
            {
                Console.WriteLine("Book ID:" + id + "not found.");
            }
        }


        // Display all book
        public void DisplayBooks()
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("No books in the library");
                return;
            }

            Console.WriteLine("Books in the library: ");
            foreach (var book in Books)
            {
                Console.WriteLine(book.DisplayAllBook());
            }
        }

            // Get Book By Atuhor
            //public void GroupBookByAthor()
            //{
            //    var bookByAuthor = book.Where( a => a.Author.Trim().Equal

            //    if (bookByAuthor.Count==0)

            //    Console.WriteLine(bookByAuthor);
            //    return bookByAuthor;
            //}



            // Search book by Author

            public List<Book> SearchByAuthor(string author)
        {
            return Books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
            
        }

        // 4 CheckStock

        public void CheckStock()
        {
            foreach (var book in Books)
            {

                if (book.QuantityInStock == 0)
                {
                    Console.WriteLine(book.Title + "Out of Stock");
                }
                else if (book.QuantityInStock < 5)
                {
                    Console.WriteLine(book.Title + "Low Stock is: " + book.QuantityInStock);
                }
                else
                {
                    Console.WriteLine(book.Title + "Quantity is: " + book.QuantityInStock);
                }
            }
        }



        // 5 GetMostExpensiveBooks(int topN)

        public List<Book> theMostExpensiveBook(int topN)
        {
            var theMostExpensiveBook = (from Book book in Books
                                        orderby book.Price descending
                                        select book).Take(topN).ToList();
            Console.WriteLine(theMostExpensiveBook);
            return theMostExpensiveBook;



        }
        //Use a lambda expression to find the total count of EBook instances in the inventory.
        public int TotalEbookInInventory()
        {
            return Books.OfType<EBook>().Count();

        }
        ///// LINQ query to group books by PublicationYear and count the number of books published each year
        //public void GroupBookByPublicationYear()
        //{
        //    var GroupBookByPublicationYear = (from Book book in Books
        //                                      orderby book.PublicationYear into PublicationYear
        //                                      select PublicationYear).ToList();
        //}

        // 6 Write a method UpdateBookPrice(int id, decimal newPrice)
        public void UpdateBookPrice(int id, decimal newPrice)
        {
            bool BookID = false;
            Console.WriteLine("Book not Found");

            foreach (var book in Books)
            {
                if (book.Price == newPrice) ;
                Console.WriteLine("Book with ID: " + id + " has been change price to: " + newPrice);
            }

        }

        // OOP
        //Write a method GenerateReport() in the Library class get the total number of book
        public void GenerateReport()
        {
            int TotalBook = Books.Count;
            Console.WriteLine("Total Book is: " + TotalBook);
        }


        // Prints the total inventory value (sum of all book prices multiplied by their quantities).
        public void TotalValue()
        {
            var TotalValue = Books.Sum(b => b.QuantityInStock * b.Price);
            Console.WriteLine("Total Value is : " + TotalValue);
        }
        // Displays the titles of all books sorted by price in descending order
        public void DisplayTheTitleSortedByPrice()
        {
            var SortedBook = from Book in Books
                             orderby Book.Price descending
                             select Book.Title.ToList();
            Console.WriteLine("Title of books sorted by price is: " + SortedBook);
        }

        //Displays the count of books published after the year 2000.
        public void DisplayBookPublishedAfterYear2000()
        {
            int count = Books.Count(a => a.PublicationYear > 2000);
            Console.WriteLine("Total amount of book release after year 2000 is: " + count);
        }



    }
}

