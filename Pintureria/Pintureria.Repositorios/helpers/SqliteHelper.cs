using Microsoft.EntityFrameworkCore;

public class SqliteHelper<Class> where Class : Entidad, ICloneable{

    DbSet<Class> dbset;
    DbContext context;

    public SqliteHelper(DbContext context, DbSet<Class> dbset){
        this.dbset = dbset;
        this.context = context;
    }
    
    public Class? buscar(long? id){
        return dbset.Where(c => c.Id == id).FirstOrDefault<Class>();
    }

    public void agregar(Class ent){
        //ent.Id = dbset.Count() == 0 ? 1 : dbset.Max(e => e.Id) + 1;
        var entidad = buscar(ent.Id);
        if(entidad==null) {
            dbset.Add((Class) ent.Clone());
            context.SaveChanges();
        }
        else throw new AlreadyRegisteredException();
    }

    public void modificar(Class ent){
        var entidad = buscar(ent.Id);
        if(entidad!=null){
            entidad = ent;
            context.SaveChanges();
        }
        else throw new NoSuchElementException();   
    }

    public void eliminar(long id){
        var entidad = buscar(id);
        if(entidad!=null){
            dbset.Remove(entidad);
            context.SaveChanges();
        }
        else throw new NoSuchElementException();  
    }

    public List<Class> listarTabla() {
        return dbset.ToList<Class>();
    }

    public long obtenerUltimoId() {
        return dbset.Count() == 0 ? 1 : dbset.Max(e => e.Id);
    }


}
