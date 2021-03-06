﻿using RabookShelf.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace RabookShelf.Data
{
    internal class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var me = new Author()
            {
                FirstName = "John",
                LastName = "A"
            };

            var julia = new Author()
            {
                FirstName = "Julienne",
                LastName = "Childs"
            };

            var book1 = new Book()
            {
                Author = julia,
                Title = "Some Book",
                Description = "Gf's book!"
            }; 
            context.Books.Add(book1);

            var book2 = new Book()
            {
                Author = me,
                Title = "Another One",
                Description = "A pretty boring one, to be true."
            };
            context.Books.Add(book2);

            context.SaveChanges();
        }
    }
}