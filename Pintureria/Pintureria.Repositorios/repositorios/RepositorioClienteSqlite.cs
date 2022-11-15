namespace Pintureria.Repositorios;
using Pintureria.Aplicacion;
public class RepositorioClienteSqlite : IRepositorio<Cliente>
{
    EntidadesContext<Cliente> context = new EntidadesContext<Cliente>();
    //FileHelper fileHelper = new FileHelper();
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
    public void delete(long id)
    {
        try
        {
            var cliente = context.Clientes
            .Where(c => c.Id == id)
            .FirstOrDefault<Cliente>();
            if(cliente!=null){
                context.Clientes.Remove(cliente);
                context.SaveChanges();
            }
            else{
                throw new NoSuchElementException();
            }
        }
        catch (NoSuchElementException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public List<Cliente> get()
    {
        return context.Clientes.ToList<Cliente>();
    }
}
