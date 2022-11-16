namespace Pintureria.Repositorios;

using Pintureria.Aplicacion;

public class RepositorioSqlite<Class> : IRepositorio<Class> where Class : Entidad {

    SqliteHelper<Class> sqliteHelper;
    EntidadesContext context = new EntidadesContext();

    public RepositorioSqlite() {
        sqliteHelper = new SqliteHelper<Class>(context, context.Set<Class>());
    }

    public void add(Class ent) {
        try {
            sqliteHelper.agregar(ent);
        }
        catch (System.Exception e) {
            Console.WriteLine(e.Message);
        }
    }

    public void modify(Class ent) {
        try {
            sqliteHelper.modificar(ent);
        }
        catch (NoSuchElementException e) {
            Console.WriteLine(e.Message);
        }
    }

    public void delete(long id)
    {
        try {
            sqliteHelper.eliminar(id);
        }
        catch (NoSuchElementException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public List<Class> get() {
        return sqliteHelper.listarTabla();
    }
}
