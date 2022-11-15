namespace Pintureria.Aplicacion;

public class ProductoUseCase{
    protected readonly IRepositorio<Producto> repositorio;
    public ProductoUseCase(IRepositorio<Producto> unRepositorio){
        repositorio = unRepositorio;
    }
}