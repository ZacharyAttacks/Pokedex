using LegendaryPokedex.Models;
using Microsoft.EntityFrameworkCore;
using Pokedex.Models;
using System.Collections.Generic;

namespace Pokedex.Data
{
    public class PokedexContext : DbContext
    {
        public PokedexContext(DbContextOptions<PokedexContext> options) : base(options) { }

        public DbSet<Pokemon> Pokemon { get; set; }
        public DbSet<Move> Moves { get; set; }
    }
}