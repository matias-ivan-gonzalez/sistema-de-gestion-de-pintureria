using Microsoft.EntityFrameworkCore;
using Pintureria.Aplicacion;
public class EntidadesContext : DbContext {

	public DbSet<Cliente> Clientes { get; set; }
	public DbSet<Producto> Productos { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
		optionsBuilder.UseSqlite("data source=Entidades.db");
	}
}