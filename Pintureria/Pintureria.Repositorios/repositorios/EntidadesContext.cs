<<<<<<< Updated upstream
using Microsoft.EntityFrameworkCore;
using Pintureria.Aplicacion;
public class EntidadesContext : DbContext {

	#nullable disable
	public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Producto> Productos { get; set; }
=======
// using Microsoft.EntityFrameworkCore;
// using Pintureria.Aplicacion;
// public class EntidadesContext<Class> : DbContext where Class : Entidad {

// 	#nullable disable
// 	public DbSet<Class> tabla { get; set; }
>>>>>>> Stashed changes

// 	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
// 		optionsBuilder.UseSqlite("data source=Entidades.db");
// 	}

// 	protected override void OnModelCreating(ModelBuilder modelBuilder){
//         modelBuilder.Entity<ClienteFisico>()
//             .HasDiscriminator<string>("Discriminator")
//             .HasValue<ClienteFisico>("ClienteFisico");

//         modelBuilder.Entity<ClienteEmpresa>()
//             .HasDiscriminator<string>("Discriminator")
//             .HasValue<ClienteEmpresa>("ClienteEmpresa");
//     }
	
// }