using Microsoft.EntityFrameworkCore;
using ProEventosAPi.Models;

namespace ProEventosAPi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Evento> Eventos { get; set; }
    }
}
