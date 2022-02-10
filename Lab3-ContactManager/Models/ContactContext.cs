using Microsoft.EntityFrameworkCore;

namespace Lab3_ContactManager.Models
{
    public class ContactContext : DbContext
    {

        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options) { }

        public DbSet<Contact> Contacts { get; set;}
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Other" }
                );

            modelBuilder.Entity<Contact>().HasData
            (
                new Contact 
                { ContactId = 1,
                  FirstName = "Frodo",
                  LastName = "Baggins",
                  Phone = "416-123-4567",
                  Email = "frodo@domain.ca",
                  CategoryId = 1,
                  DateAdded = DateTime.Now
                },

                new Contact 
                { ContactId = 2,
                  FirstName = "Sawise",
                  LastName = "Gamgree",
                  Phone = "647-123-4567",
                  Email = "sawise@domain.ca",
                  CategoryId = 2,
                  DateAdded = DateTime.Now
                },

                new Contact 
                { ContactId = 3,
                  FirstName = "Pippen",
                  LastName = "Took",
                  Phone = "905-123-4567",
                  Email = "pippen@domain.ca",
                  CategoryId = 3,
                  DateAdded = DateTime.Now
                }
             );
        }

    }
}
