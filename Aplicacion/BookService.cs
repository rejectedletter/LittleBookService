using AccesoDatos;
using System;
using System.Linq;
using System.Collections.Generic;
using Dominio.Entities;

namespace Aplicacion
{
    public class BookService
    {

        public BookService()
        {
            Add(new Book() { id = Guid.NewGuid(), title = "Catcher in a Rye.", author = "J. D. Sallinger", read = true });
        }
        public List<Book> GetAll()
        {
            var books = new List<Book>();

            using (var context = new ServiceContext())
            {
               books = context.Books.ToList();
            }

            return books;
        }

        public void Add(Book book)
        {
            var newBook = new Book();

            using (var context = new ServiceContext())
            {
                context.Add(book);
                context.SaveChangesAsync();
            }
        }
    }
}
