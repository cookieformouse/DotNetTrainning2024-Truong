using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combine_Asignment
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int PublicationYear { get; set; }
        public int QuantityInStock { get; set; }

        // Constructor

        public Book(int id, string title, string author, decimal price, int publicationYear, int quantityInStock)
        {
            ID = id;
            Title = title;
            Author = author;
            Price = price;
            PublicationYear = publicationYear;
            QuantityInStock = quantityInStock;
        }

        public virtual string DisplayAllBook() 
        {
            return $"ID: {ID}, Title: {Title}, Author: {Author}, Price: ${Price}, " +
        $"Publication Year: {PublicationYear}, Stock: {QuantityInStock}";

        }


    }

}
