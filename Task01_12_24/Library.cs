using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01_12_24
{
    public class Library
    {
        private List<Book> _books= new List<Book>();

        public List<Book> GetBooks()
        {
            return _books;
        }

        public Book this[int index]
        {
            get { return _books[index]; }
        }

        public void AddBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException("Book cannot be null");
            }
            _books.Add(book);
        }

        public List<Book> FindAllBooksByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return new List<Book>();

            return _books.FindAll(b=>b.Name.ToLower().Contains(name.ToLower()));
        }

        public Book FindBookByCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code)) return null;

            return _books.FirstOrDefault(b => b.Code.ToLower() == code.ToLower());
        }

        public void RemoveAllBooksByName(string name)
        {
             if (string.IsNullOrWhiteSpace(name)) return;

             _books.RemoveAll(b=>b.Name.ToLower() == name.ToLower());
        }

        public List<Book> SearchBooks(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return new List<Book>();

            return _books.Where(b => b.Name != null && b.Name.ToLower().Contains(value.ToLower())|| 
            b.AuthorName != null && b.AuthorName.ToLower().Contains(value.ToLower()) ||
            b.PageCount.ToString().Contains(value)).ToList();
        }
        public List<Book> FindAllBooksByPageCountRange(int minPages, int maxPages)
        {
            return _books.Where(b => b.PageCount >= minPages && b.PageCount <= maxPages).ToList();

           
        }

        public void RemoveBookByCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code)) return;

      
            if(FindBookByCode(code)!=null)
            {
                _books.Remove(FindBookByCode(code));
            }
        }

    }
}
