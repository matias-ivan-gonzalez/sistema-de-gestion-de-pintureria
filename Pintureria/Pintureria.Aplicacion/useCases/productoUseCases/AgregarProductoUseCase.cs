namespace Pintureria.Aplicacion;

public class AgregarProductoUseCase : ProductoUseCase{

    public AgregarProductoUseCase(IRepositorio<Producto> repositorio) : base(repositorio){}

    public void Ejecutar(Producto producto){
        repositorio.add(producto);
    }

}