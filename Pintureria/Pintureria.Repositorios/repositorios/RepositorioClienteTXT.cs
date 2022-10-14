namespace Pintureria.Repositorios;
using Pintureria.Aplicacion;
public class RepositorioClienteTXT : IRepositorioCliente {
    FileHelper fileHelper = new FileHelper();
    public RepositorioClienteTXT(){}

    public void add(Cliente cli){
        string? cliente = fileHelper.buscarCliente(cli.Id);
        fileHelper.agregarClienteNoExistente(cliente, cli);
    }

    public void modify(Cliente cli){
        string? archivo = fileHelper.obtenerArchivoCompleto();
        string? actual = fileHelper.buscarCliente(cli.Id);
        fileHelper.sobreEscribirArchivoPorAlteracion(archivo,actual,cli);
    }
    public void delete(int id){
        string? cliente = fileHelper.buscarCliente(id);
        if(cliente != null){
            List<string> archivo = get();
            fileHelper.eliminarCliente(id,archivo);
        }
    }

    public List<string> get(){
        return fileHelper.obtenerEntidadesDeArchivoEnLista();
    }
}
