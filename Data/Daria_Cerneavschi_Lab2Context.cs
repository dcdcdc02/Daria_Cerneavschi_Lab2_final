using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Daria_Cerneavschi_Lab2.Models;

namespace Daria_Cerneavschi_Lab2.Data
{
    public class Daria_Cerneavschi_Lab2Context : DbContext
    {
        public Daria_Cerneavschi_Lab2Context (DbContextOptions<Daria_Cerneavschi_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Daria_Cerneavschi_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Daria_Cerneavschi_Lab2.Models.Author> Authors { get; set; } = default!;

        public DbSet<Daria_Cerneavschi_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
