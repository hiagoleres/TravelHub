using Microsoft.EntityFrameworkCore;
using TravelHub.Models.Usuario;

namespace TravelHub.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
