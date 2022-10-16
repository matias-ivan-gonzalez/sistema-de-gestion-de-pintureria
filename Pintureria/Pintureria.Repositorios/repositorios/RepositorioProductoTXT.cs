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
        try{
            fileHelper.modificarProducto(pro);
        }
        catch (NoSuchElementException e){
            Console.WriteLine(e.Message);
        }
    }
    public void delete(string id){
        try{
            fileHelper.removerProducto(id);
        }
        catch (NoSuchElementException e){
            Console.WriteLine(e.Message);
        }
    }
    public List<string> get(){
        return fileHelper.getProductos();
    }
}
