using AccesoDatos;
using System;
using System.Linq;
using System.Collections.Generic;
using Dominio.Entities;
using Infraestructura;

namespace Aplicacion
{
    public class BookService
    {

        public BookService()
        {

        }
        public List<Book> GetAll()
        {
            var books = new List<Book>();

            using (var context = new ConectionMySql())
            {
                books = context.Books.ToList();
            }

            return books;
        }

        public Book GetById(Guid id)
        {
            var searchedBook = new Book();

            using (var context = new ConectionMySql())
            {
                searchedBook = context.Books.FirstOrDefault(b => b.id == id);
            }

            return searchedBook;
        }

        public void Add(Book book)
        {
            var newBook = new Book();

            using (var context = new ConectionMySql())
            {
                var ini = context.Add(book);
                var res = context.SaveChanges();
            }
        }

        public void Update (Guid id, string title, string author, bool read = false)
        {
            int iRetorno;
            if (GetById(id) is null)
            {
                throw new Exception("No se encontró libro");
            }
            var updateBook = GetById(id);
            updateBook.title = title;
            updateBook.author = author;
            updateBook.read = read;

            using (var context = new ConectionMySql())
            {
                try
                {
                    var ini = context.Update(updateBook);
                    context.SaveChangesAsync();
                }
                catch(Exception ex)
                {
                }
            }
        }
        
    }
}
