namespace Pintureria.Aplicacion;

public class ProductoUseCase{
    protected readonly IRepositorioProducto repositorio;
    public ProductoUseCase(IRepositorioProducto unRepositorio){
        repositorio = unRepositorio;
    }
}