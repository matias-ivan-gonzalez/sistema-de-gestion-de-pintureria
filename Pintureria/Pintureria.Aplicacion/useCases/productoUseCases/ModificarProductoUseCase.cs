namespace Pintureria.Aplicacion;

public class ModificarProductoUseCase : UseCase{

    public ModificarProductoUseCase(IRepositorioProducto repositorio) : base(repositorio){}

    public void Ejecutar(Producto producto){
        repositorio.modify(producto);
    }

}