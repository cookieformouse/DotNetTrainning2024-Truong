using Combine_Asignment;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

// 1 Define a Book Class

class Program
{ 
//{
//    private static NhapSach()
//    {
//        int id;
//        string title;
//        string author;
//        decimal price;
//        int publicationYear;
//        int quantityInStock;

//        Console.WriteLine("Input ID: ");
//        id = int.Parse(Console.ReadLine());

//        Console.WriteLine("Input Tittle: ");
//        title = Console.ReadLine();

//        Console.WriteLine("Input Author");
//        author = Console.ReadLine();

//        Console.WriteLine("Input Price");
//        price = int.Parse(Console.ReadLine());

//        Console.WriteLine("Input Year Publication");
//        publicationYear = int.Parse(Console.ReadLine());

//        Console.WriteLine("Input Quantity");
//        quantityInStock = int.Parse(Console.ReadLine());

//        //Book Conanbook = new Book(1, "Conan", "Truong", 50, 2002, 100);
//        //bookdatabase.AddBook(Conanbook);

    
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Library bookDatabase = new Library();
        
        Book Programming = new Book(1, "C# Programming", "John Doe",  29.99m, 2018, 10);
        bookDatabase.AddBook(Programming);

        Book EffectiveLINQ = new Book(2, "Effective LINQ", "Jane Smith", 39.99m, 2015, 4);
        bookDatabase.AddBook(EffectiveLINQ);

        Book MasteringC= new Book(3, "Mastering C# ", "John Doe",  49.99m, 2021, 0);
        bookDatabase.AddBook(MasteringC);

        Console.WriteLine(bookDatabase.Books.Count);

        bookDatabase.CheckStock();

        bookDatabase.theMostExpensiveBook(3);

        bookDatabase.UpdateBookPrice( 1, 35.99m );

        bookDatabase.GenerateReport();

        bookDatabase.TotalValue();

        bookDatabase.DisplayTheTitleSortedByPrice();

        bookDatabase.DisplayBookPublishedAfterYear2000();



       var b= bookDatabase.SearchByAuthor("John Doe");
        foreach (var item in b)
        {
            Console.WriteLine(item.DisplayAllBook());
        }
       








    }
    
}
