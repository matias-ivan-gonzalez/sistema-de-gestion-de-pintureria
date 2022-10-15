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
            string? actual = fileHelper.buscarCliente(cli.Id);
            string? archivo = fileHelper.obtenerArchivoCompleto();
            fileHelper.sobreEscribirArchivoPorAlteracion(archivo,actual,cli);
        }
        catch (NoSuchElementException e){
            Console.WriteLine(e.Message);
        }
    }
    public void delete(int id){
        try{
            fileHelper.buscarCliente(id);        
            List<string> archivo = get();
            fileHelper.eliminarCliente(id,archivo);
        }
        catch (NoSuchElementException e){
            Console.WriteLine(e.Message);
        }   
    }

    public List<string> get(){
        return fileHelper.obtenerEntidadesDeArchivoEnLista();
    }
}
