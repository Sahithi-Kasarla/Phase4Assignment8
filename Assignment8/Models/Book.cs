using System;
using System.Collections.Generic;

namespace Assignment8.models
{
    public partial class Book
    {
        public Book()
        {
            BookAuthors = new HashSet<BookAuthor>();
        }

        public int BookId { get; set; }
        public string? BookName { get; set; }
        public decimal? Price { get; set; }
        public int? CategoryId { get; set; }
        public int? PublisherId { get; set; }

        public virtual BookCategory? Category { get; set; }
        public virtual Publisher? Publisher { get; set; }
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
