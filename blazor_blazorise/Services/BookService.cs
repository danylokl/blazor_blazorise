using blazor_blazorise.Models;

namespace blazor_blazorise.Services
{
    public class BookService
    {
        private List<Book> Books = new List<Book> {
           new Book {Title="title1",Author="author1",Content="content fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff1",Genre="gentre11", Cover="/626.png",Reviews=new List<Review> { new Review {Message="some message",Reviewer="Jon",Score=2 }  } }
       };
        public List<Book> GetAllBooks()
        {
            return Books;

        }
        public void AddNewBook(Book book)
        {
            Books.Add(book);
        }
        public void EditBook (Book book)
        {
            Books.Select(a => a = book).Where(i => i.Title == book.Title);
        }
    }
}
