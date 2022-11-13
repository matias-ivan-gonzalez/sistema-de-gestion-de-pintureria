using Microsoft.EntityFrameworkCore;

public class EntidadesContext : DbContext {

	public DbSet<Alumno> Alumnos { get; set; }
	public DbSet<Examen> Examenes { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
		optionsBuilder.UseSqlite("data source=Entidades.db");
	}
}