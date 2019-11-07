using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class GameStoreContext : DbContext
    {
        public DbSet<JogoModel> Jogo { get; set; }
        public DbSet<GeneroModel> Genero { get; set; }
        public GameStoreContext(DbContextOptions options): base(options) { }
    }
}
