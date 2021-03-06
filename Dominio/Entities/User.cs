using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entities
{
    public class User
    {
        public Guid id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string userName { get; set; }

        public string password { get; set; }

        public string email { get; set; }

        public string address { get; set; }

        public string phone { get; set; }
    }
}
