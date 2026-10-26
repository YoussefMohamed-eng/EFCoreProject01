using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using EFCoreProject01.Models;

namespace EFCoreProject01.Data
{
    internal class BookStoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = BookStoreDB ; Trusted_Connection=True; TrustServerCertificate=True ");
        }
        public DbSet<Book>Books { get; set; }
        public DbSet<Author>Authors { get; set; }
        public DbSet<Category>Categories { get; set; }
    }
}
