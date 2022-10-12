namespace Pintureria.Aplicacion;
public interface IRepositorioProducto : IRepositorio{
    public bool add(Producto pro);
    public bool modify(Producto pro);
}