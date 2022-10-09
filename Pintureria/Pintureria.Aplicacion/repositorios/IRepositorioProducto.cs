namespace Pintureria.Aplicacion;
public interface IRepositorioProducto{
    
    public bool add(Producto producto);
    public bool modify(Producto producto);
    public bool delete(int id);
    public bool get();
}