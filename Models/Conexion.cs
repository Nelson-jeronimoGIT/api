using Microsoft.EntityFrameworkCore;
namespace ApiEmpresa.Models;
public class conexiones : DbContext{
    public conexiones(DbContextOptions<conexiones> options)
        : base(options)
    {
    }

    public DbSet<Clientes> Clientes  { get; set; } = null!;
}
} 