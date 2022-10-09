namespace Pintureria.Aplicacion;

public class ModificarProductoUseCase{

    IRepositorioProducto repositorio;

    public ModificarProductoUseCase(IRepositorioProducto unRepositorio){
        repositorio = unRepositorio;
    }

    public void Ejecutar(Producto producto){
        repositorio.modify(producto);
    }

}