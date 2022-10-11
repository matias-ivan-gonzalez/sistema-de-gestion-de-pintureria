namespace Pintureria.Aplicacion;

public class ModificarProductoUseCase : ProductoUseCase{

    public ModificarProductoUseCase(IRepositorioProducto repositorio) : base(repositorio){}

    public void Ejecutar(Producto producto){
        repositorio.modify(producto);
    }

}