using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    internal class Book
    {
        private static int IdGenerator = 1;
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Author { get; set; }
        private string isbn;
        public string ISBN
        {
            get { return isbn; }
            set
            {
                if (!isValidIsbn(value))
                {
                    throw new Exception("ISBN has to have 13 numbers!");
                }
            }
        }

        public Book(string isbn, string title, string author)
        {
            Id = IdGenerator++;
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"ID: {Id}\nISBN: {ISBN}\nTitle: {Title}\nAuthor: {Author}";
        }

        private bool isValidIsbn(string value)
        {
            if (value.Length != 13)
            {
                return false;
            }

            foreach (char c in value)
            {
                if (!char.IsDigit(c)) { return false; }
            }
            return true;

            // skraceno
            // return value.All(c => !char.IsDigit(c));
        }
    }
}
