﻿using RabookShelf.Models;
using System.Data.Entity;

namespace RabookShelf.Data
{
    public class Context : DbContext  
    {      
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DbSet Book { get; set; }
        public DbSet Author { get; set; }
        public DbSet BookSize { get; set; }
        public DbSet BookType { get; set; }
        //public DbSet MyProperty { get; set; }


        public Context()
        {           
            Database.SetInitializer(new DatabaseInitializer());
        }

    }
}