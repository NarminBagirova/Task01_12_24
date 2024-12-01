namespace Task01_12_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            
            library.AddBook(new Book("Don Quixote", "Miguel de Cervantes", 500, 1));
            library.AddBook(new Book("Alice's Adventures in Wonderland", "Lewis Carroll", 150, 2));
            library.AddBook(new Book("The Adventures of Huckleberry Finn", "Mark Twain", 300, 3));
            library.AddBook(new Book("The Adventures of Tom Sawyer", "Mark Twain", 250, 4));

            Console.WriteLine("Books in the Library:");
            foreach (var book in library.GetBooks())
            {
                Console.WriteLine($"Book Name: {book.Name}, Author: {book.AuthorName}, Code: {book.Code}, Pages: {book.PageCount}");
            }

            var bookByCode = library.FindBookByCode("DO1");

            if (bookByCode != null)
            {
                Console.WriteLine($"\nFound by code 'DQ1': {bookByCode.Name}");
            }
            else
            {
                Console.WriteLine("\nFound by code 'DQ1': Not Found");
            }

            var searchResults = library.SearchBooks("Adventures");
            Console.WriteLine("\nSearch results for 'Adventures':");
            foreach (var book in searchResults)
            {
                Console.WriteLine($" {book.Name} by {book.AuthorName}");
            }

            library.RemoveAllBooksByName("Huckleberry");
            Console.WriteLine("\nAfter removing books with 'Huckleberry' in the name:");
            foreach (var book in library.GetBooks())
            {
                Console.WriteLine($"- {book.Name}");
            }

        }
    }
}