namespace Pintureria.Repositorios;
using Pintureria.Aplicacion;
public class RepositorioClienteSqlite : IRepositorioCliente
{
    EntidadesContext context = new EntidadesContext();
    FileHelper fileHelper = new FileHelper();
    public RepositorioClienteSqlite() { }

    public void add(Cliente cli) {
        try {
            var cliente = context.Clientes
            .Where(c => c.Id == cli.Id)
            .FirstOrDefault<Cliente>();
            if(cliente==null) {
                context.Clientes.Add(cli);
                context.SaveChanges();
            }
            else{
                throw new AlreadyRegisteredException();
            }
        }
        catch (System.Exception e) {
            Console.WriteLine(e.Message);
        }
    }

    public void modify(Cliente cli) {
        try {
            var cliente = context.Clientes
            .Where(c => c.Id == cli.Id)
            .FirstOrDefault<Cliente>();
            if(cliente!=null){
                cliente = cli;
                context.SaveChanges();
            }
            else{
                throw new NoSuchElementException();
            }
        }
        catch (NoSuchElementException e) {
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
