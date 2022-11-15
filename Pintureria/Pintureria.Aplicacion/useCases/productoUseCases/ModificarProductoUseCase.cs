namespace Pintureria.Aplicacion;

public class ModificarProductoUseCase : ProductoUseCase{

    public ModificarProductoUseCase(IRepositorio<Producto> repositorio) : base(repositorio){}

    public void Ejecutar(Producto producto){
        repositorio.modify(producto);
    }

}