using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ADV_Business_Final_Project
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<LibraryContext>();

            // Ensure the database is created.
            context.Database.EnsureCreated();

            // Seed the Books table if it doesn't have any data.
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction" },
                    new Book { Title = "1984", Author = "George Orwell", Genre = "Dystopian" },
                    new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction" }
                );
                context.SaveChanges();
            }

            // Seed the Borrowers table if it doesn't have any data.
            if (!context.Borrowers.Any())
            {
                context.Borrowers.AddRange(
                    new Borrower { Name = "Alice Johnson", Email = "alice.johnson@example.com" },
                    new Borrower { Name = "Bob Smith", Email = "bob.smith@example.com" },
                    new Borrower { Name = "Charlie Davis", Email = "charlie.davis@example.com" }
                );
                context.SaveChanges();
            }
        }
    }
}
