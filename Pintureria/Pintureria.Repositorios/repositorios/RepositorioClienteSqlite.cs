namespace Pintureria.Repositorios;
using Pintureria.Aplicacion;
public class RepositorioClienteSqlite : IRepositorio<Cliente>
{
    EntidadesContext context;
    SqliteHelper<Cliente> sqliteHelper;
    public RepositorioClienteSqlite() {
        context = new EntidadesContext();
        sqliteHelper = new SqliteHelper<Cliente>(context, context.Clientes);
    }

    public void add(Cliente cli) {
        try {
            sqliteHelper.agregar(cli);
        }
        catch (System.Exception e) {
            Console.WriteLine(e.Message);
        }
    }

    public void modify(Cliente cli) {
        try {
            sqliteHelper.modificar(cli);
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

    public List<Cliente> get() {
        return sqliteHelper.listarTabla();
    }
}
