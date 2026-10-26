using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject01.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int PublishedYear { get; set; }
        public bool IsInStock { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }

        public Author Author { get; set; } = null!;

        public Category Category { get; set; } = null!;



    }
}
