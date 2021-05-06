using Microsoft.EntityFrameworkCore;
using projetomvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetomvc.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            :base(options)
        {
        }

        public DbSet<Movies> Movies { get; set; }
    }
}
