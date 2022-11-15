using Microsoft.EntityFrameworkCore;

public class SqliteHelper<Class, set> where Class : Entidad where set : DbSet<Class> {
    EntidadesContext context = new EntidadesContext();

    public Class buscar(long id){
        return set.Where(c => c.Id == id).FirstOrDefault<Class>();
    }
}
