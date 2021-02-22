using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Book_Project.Models;

namespace Book_Project.Data
{
    public class Book_ProjectContext : DbContext
    {
        public Book_ProjectContext (DbContextOptions<Book_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Book_Project.Models.Book> Book { get; set; }
    }
}
