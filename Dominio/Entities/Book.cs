using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entities
{
    public class Book
    {
        public Guid id { get; set; }

        public string title { get; set; }

        public string author { get; set; }

        public bool read { get; set; } = false;
    }
}
