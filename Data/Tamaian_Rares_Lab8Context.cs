using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tamaian_Rares_Lab8.Models;

namespace Tamaian_Rares_Lab8.Data
{
    public class Tamaian_Rares_Lab8Context : DbContext
    {
        public Tamaian_Rares_Lab8Context (DbContextOptions<Tamaian_Rares_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Tamaian_Rares_Lab8.Models.Book> Book { get; set; }

        public DbSet<Tamaian_Rares_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
