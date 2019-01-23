using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GamesAPI.Models
{
    public class GamesContext : DbContext
    {
        public GamesContext()
        { }

        public GamesContext(DbContextOptions<GamesContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
    }
}
