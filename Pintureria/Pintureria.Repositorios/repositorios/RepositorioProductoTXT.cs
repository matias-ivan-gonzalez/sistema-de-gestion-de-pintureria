namespace Pintureria.Repositorios;
using Pintureria.Aplicacion;
public class RepositorioProductoTXT : IRepositorioProducto {
    FileHelper fileHelper = new FileHelper();
    public RepositorioProductoTXT(){}

    public void add(Producto pro){
        string? cliente = fileHelper.buscarProductoParaInsercion(pro.Id);
        fileHelper.agregarProductoNoExistente(cliente, pro);
    }
    public void modify(Producto pro){
        fileHelper.modificarProducto(pro);
    }
    public void delete(int id){
        
    }
    public List<string> get(){
        return fileHelper.obtenerEntidadesDeArchivoEnLista();
    }
}
