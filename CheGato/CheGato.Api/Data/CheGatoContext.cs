using CheGato.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CheGato.Api.Data
{
    public class CheGatoContext : DbContext
    {
        public CheGatoContext(DbContextOptions<CheGatoContext> options) : base(options) { }

       
        public DbSet<Producto> Productos { get; set; }
    }
}