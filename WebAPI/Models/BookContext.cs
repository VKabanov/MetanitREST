using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebAPI.Models
{
    public class BookContext : DbContext
    {
        public BookContext(String ConnectionString) : base(ConnectionString) { }
        public DbSet<Book> Books { get; set; }
    }
}