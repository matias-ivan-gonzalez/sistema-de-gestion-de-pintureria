namespace Pintureria.Repositorios;
using Pintureria.Aplicacion;
public class RepositorioProductoTXT : IRepositorio<Producto> {
    //FileHelper fileHelper = new FileHelper();
    public RepositorioProductoTXT(){}

    public void add(Producto pro){
        try {
        //fileHelper.validarValores(pro);
        //string? producto = fileHelper.buscarProductoParaInsercion(pro.Id);
        //fileHelper.agregarProductoNoExistente(producto, pro);
        } 
        catch(NegativeValueNotAllowedException e){
            Console.WriteLine(e.Message);
        }

    }
    public void modify(Producto pro){
        try{
            //fileHelper.validarValores(pro);
            //fileHelper.modificarProducto(pro);
        }
        catch (System.Exception e){
            Console.WriteLine(e.Message);
        }
    }
    public void delete(long id){
        try{
            //fileHelper.removerProducto(id);
        }
        catch (NoSuchElementException e){
            Console.WriteLine(e.Message);
        }
    }
    public List<Producto> get(){
        //return fileHelper.getProductos();
        return null;
    }
}
