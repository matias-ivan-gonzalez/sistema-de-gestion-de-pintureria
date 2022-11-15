namespace Pintureria.Aplicacion;

public class EliminarProductoUseCase : ProductoUseCase{

    public EliminarProductoUseCase(IRepositorio<Producto> repositorio) : base(repositorio){}

    public void Ejecutar(long id){
        repositorio.delete(id);
    }

}