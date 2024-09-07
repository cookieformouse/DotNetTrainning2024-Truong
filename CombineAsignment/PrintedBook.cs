using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combine_Asignment
    //create derived classes from Book: PrintedBook.
{
    public class PrintedBook : Book
    {
        public int PageCount { get; set; }
        public PrintedBook(int id, string title, string author, decimal price, int publicationYear, int quantityInStock, int pageCount) : base(id, title, author, price, publicationYear, quantityInStock)
        {
          
            PageCount = pageCount;
        }
    }
}
