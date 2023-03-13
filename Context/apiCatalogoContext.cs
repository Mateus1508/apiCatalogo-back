using apiCatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace apiCatalogo.Context;

public class apiCatalogoContext : DbContext
{
    public apiCatalogoContext(DbContextOptions<apiCatalogoContext> options) : base(options) 
    { 
        
    }
    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Produto>? Produtos { get; set; }
}
