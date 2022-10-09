namespace Pintureria.Aplicacion;

public class AgregarProductoUseCase{

    IRepositorioProducto repositorio;

    public AgregarProductoUseCase(IRepositorioProducto unRepositorio){
        repositorio = unRepositorio;
    }

    public void Ejecutar(Producto producto){
        repositorio.add(producto);
    }

}