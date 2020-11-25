using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Andrada_Pop_Lab8.Models;

namespace Andrada_Pop_Lab8.Data
{
    public class Andrada_Pop_Lab8Context : DbContext
    {
        public Andrada_Pop_Lab8Context (DbContextOptions<Andrada_Pop_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Andrada_Pop_Lab8.Models.Book> Book { get; set; }

        public DbSet<Andrada_Pop_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Andrada_Pop_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
