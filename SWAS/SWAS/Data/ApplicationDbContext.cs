using Microsoft.EntityFrameworkCore;
using SWAS.Models;

namespace SWAS.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        //Agregar los modelos
        public DbSet<Usuarios> Usuario { get; set; }
    }
}
