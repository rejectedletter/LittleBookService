using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Infraestructura
{
    public class ConectionMySql : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }


        string CnxMySql = "Server=localhost; Port=3306; Database=pjproject; Uid=dba; Pwd=gestion525;";

        public IDbConnection GetConexionIm()
        {
            IDbConnection dbConnection = new MySqlConnection(CnxMySql);
            return dbConnection;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseMySql(CnxMySql,ServerVersion.AutoDetect(CnxMySql));
            optionsBuilder.UseMySql(CnxMySql,ServerVersion.AutoDetect(CnxMySql));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
