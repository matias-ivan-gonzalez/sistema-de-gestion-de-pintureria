namespace Pintureria.Aplicacion;
public interface IRepositorioProducto : IRepositorio{
    public void add(Producto pro);
    public void modify(Producto pro);
}