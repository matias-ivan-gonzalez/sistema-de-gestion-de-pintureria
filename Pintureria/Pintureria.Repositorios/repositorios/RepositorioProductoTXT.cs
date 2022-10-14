namespace Pintureria.Repositorios;
using Pintureria.Aplicacion;
public class RepositorioProductoTXT : IRepositorioProducto {
    FileHelper fileHelper = new FileHelper();
    public RepositorioProductoTXT(){}

    public void add(Producto pro){
    }
    public void modify(Producto pro){
    }
    public void delete(int id){
    }
    public List<string> get(){
        return fileHelper.obtenerEntidadesDeArchivoEnLista();
    }
}
