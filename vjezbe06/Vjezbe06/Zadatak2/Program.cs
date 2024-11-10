using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("1234567890123", "Heri poter", "J.K. Rownling");
            Book book2 = new Book("1234567890123", "Heri poter2", "J.K. Rownling");
            Book book3 = new Book("1234567890123", "Heri poter3", "J.K. Rownling");

            List<Book> books = new List<Book>() { book1, book2, book3};

            foreach (Book book in books) 
            { 
                Console.WriteLine(book.ToString());
                Console.WriteLine("\n");
            }

            try
            {
                Book book4 = new Book("123456789012", "Heri poter3", "J.K. Rownling");
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
            }


        

        }
    }
}
