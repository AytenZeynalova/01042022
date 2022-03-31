using System;

namespace _01042022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" book name ");
            string bookName = "periler nagili" ;
            Console.WriteLine(" book genre ");
            string bookGenre = "nagil";
            Console.WriteLine(" book author ");
            string bookAuthor = "asya";
            Console.WriteLine(" book price ");
            double bookPrice = 6;


            Book book = new Book()
            {
                Name = bookName,
                Genre = bookGenre,
                Author = bookAuthor,
                Price = bookPrice
            };

            Console.WriteLine(" book name ");
            string book1Name = "dehsetler adasi";
            Console.WriteLine("book genre ");
            string book1Genre = "qorxulu";
            Console.WriteLine("book author");
            string book1Author = "ayten";
            Console.WriteLine("book price ");
            double book1Price =15;

            Book book1 = new Book()
            {
                Name = book1Name,
                Genre = book1Genre,
                Author = book1Author,
                Price = book1Price
            };

           
        }
    }
}
