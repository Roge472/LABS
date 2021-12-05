using System;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace DraftLab.OriginalLibrary
{
    // Class takes responsibilities of child classes.
    public class Librarian
    {
        public void DoWork(Library library)
        {
            // data
            Guid studentId = Guid.NewGuid();
            Guid studentId2 = Guid.NewGuid();
            Guid studentId3 = Guid.NewGuid();
            string firstAuthor = "Terry Pratchett";
            string firstBookName = "Soul music";
            string secondAuthor = "Nikolai Ostrovsky";
            string secondBookName = "How the Steel Was Tempered";

            // When Librarian comes to work he sorts books.
            library.SortCatalog();

            // New books were delivered
            library.AddBook(firstAuthor, firstBookName, DateTime.UtcNow);
            library.AddBook(secondAuthor, secondBookName, DateTime.UtcNow);

            // Some new readers come to library to register
            Registry registry = library.Registry;
            library.AddReader("Badger", studentId);
            library.AddReader("Bagool", studentId2);
            library.AddReader("Pigeon", studentId3);

            // Some readers take books
            var readerInfo = registry.Readers.FirstOrDefault(r => r.StudentId == studentId);
            var bookRecords = library.GetRecords();
            var book = library.GetBook(bookRecords.First().BookId);
            library.TakeBook(book, readerInfo);

            // Some reader return books
            library.ReturnBook(book);
        }
    }


    public class Library
    {
        public Catalog Catalog { get; } = new Catalog();
        public Registry Registry { get; } = new Registry();

        public void SortCatalog()
        {
            Console.WriteLine("Some unchangeable sorting schema!");
            Catalog.Books.Sort();
        }

        public void AddReader(string name, Guid studentId)
        {
            var doesStudentExist = Registry.Readers.FirstOrDefault(r => r.StudentId == studentId) != null;
            if (doesStudentExist)
            {
                throw new Exception("student already exists");
            }

            Registry.Readers.Add(new Reader { StudentId = studentId, Name = name });
        }

        public void AddBook(string author, string name, DateTime published)
        {
            // Simulate meaningful work
            Catalog.Books.Add(new Book { Author = author, Name = name, Published = published, IsInLibrary = true });
            Catalog.Books.Sort((book, book1) => string.CompareOrdinal(book.Author, book1.Author));
        }

        public Book GetBook(Guid bookId)
        {
            return Catalog.Books.Find(b => b.Id == bookId);
        }

        public Book TakeBook(Book book, Reader reader)
        {
            var libraryBook = Catalog.Books.Find(b => b.Id == book.Id);
            libraryBook.Readers.Add(reader);
            libraryBook.IsInLibrary = false;
            return libraryBook;
        }

        public void ReturnBook(Book book)
        {
            var libraryBook = Catalog.Books.Find(b => b.Id == book.Id);
            libraryBook.IsInLibrary = true;
        }

        public List<BookRecord> GetRecords()
        {
            var records = Catalog.Books.Select(b => new BookRecord { BookId = b.Id, Name = b.Name, IsInLibrary = b.IsInLibrary }).ToList();
            return records;
        }
    }

    public class Book
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime Published { get; set; }
        public List<Reader> Readers { get; set; } = new List<Reader>();
        public bool IsInLibrary { get; set; }
    }

    public class Registry
    {
        public List<Reader> Readers { get; } = new List<Reader>();
        public List<Librarian> Librarians { get; } = new List<Librarian>();
    }

    public class Catalog
    {
        public string GOST { get; set; }
        public List<Book> Books { get; } = new List<Book>();
    }

    public class Reader
    {
        public string Name { get; set; }
        public Guid StudentId { get; set; }
    }

    public class BookRecord
    {
        public Guid BookId { get; set; }
        public string Name { get; set; }
        public bool IsInLibrary { get; set; }
    }
}
