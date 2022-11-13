namespace Pintureria.Repositorios;
using Pintureria.Aplicacion;
public class RepositorioClienteSqlite : IRepositorioCliente
{
    EntidadesContext context = new EntidadesContext();
    FileHelper fileHelper = new FileHelper();
    public RepositorioClienteSqlite() { }

    public void add(Cliente cli) {
        var cliente = context.Clientes
            .Where(c => c.Id == cli.Id)
            .FirstOrDefault<Cliente>();
        if(cliente==null) {
            context.Clientes.Add(cli);
            context.SaveChanges();
        }
    }

    public void modify(Cliente cli)
    {
        try
        {
            fileHelper.modificarCliente(cli);
        }
        catch (NoSuchElementException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public void delete(string id)
    {
        try
        {
            fileHelper.removerCliente(id);
        }
        catch (NoSuchElementException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public List<string> get()
    {
        return fileHelper.getClientes();
    }
}
