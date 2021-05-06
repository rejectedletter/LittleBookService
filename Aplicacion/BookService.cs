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

        public void Add(Book book)
        {
            var newBook = new Book();

            using (var context = new ConectionMySql())
            {
                context.Add(book);
                context.SaveChangesAsync();
            }
        }
        
    }
}
