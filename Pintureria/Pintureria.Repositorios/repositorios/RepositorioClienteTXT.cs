namespace Pintureria.Repositorios;
using Pintureria.Aplicacion;
public class RepositorioClienteTXT : IRepositorioCliente {
    FileHelper fileHelper = new FileHelper();
    public RepositorioClienteTXT(){}

    public void add(Cliente cli){
        string? cliente = fileHelper.buscarClienteParaInsercion(cli.Id);
        fileHelper.agregarClienteNoExistente(cliente, cli);            
    }

    public void modify(Cliente cli){
        try{
            fileHelper.modificarCliente(cli);
        }
        catch (NoSuchElementException e){
            Console.WriteLine(e.Message);
        }
    }
    public void delete(string id){
        try{
            fileHelper.removerCliente(id);
        }
        catch (NoSuchElementException e){
            Console.WriteLine(e.Message);
        }   
    }

    public List<string> get(){
        return fileHelper.getClientes();
    }
}
