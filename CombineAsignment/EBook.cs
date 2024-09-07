using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combine_Asignment
{
    //create derived classes from Book: EBook 
    internal class EBook : Book
    {

        public double FileSize { get; set; }
        public EBook(int id, string title, string author, decimal price, int publicationYear, int quantityInStock, double fileSize) : base(id, title, author, price, publicationYear, quantityInStock)
        {

            FileSize = fileSize;
        }

        public override string DisplayAllBook()
        {
            return base.DisplayAllBook() + $"File MB:{FileSize}"; 
        }
    }

    
}
