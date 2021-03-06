using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Sample1
{
    class BookShelf : Aggregate<Book>
    {
        public IEnumerable<Book> elements
        {
            get
            {
                return books;
            }
        }
        private List<Book> books = new List<Book>();

        public void appendBook(Book book)
        {
            books.Add(book);
        }

        public Book getBookAt(int index)
        {
            return books.Count <= index ? null : books[index];
        }

        public int getLength()
        {
            return books.Count;
        }
    }
}
