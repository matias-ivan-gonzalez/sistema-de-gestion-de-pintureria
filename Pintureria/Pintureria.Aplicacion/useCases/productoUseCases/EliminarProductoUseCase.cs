namespace Pintureria.Aplicacion;

public class EliminarProductoUseCase{

    IRepositorioProducto repositorio;

    public EliminarProductoUseCase(IRepositorioProducto unRepositorio){
        repositorio = unRepositorio;
    }

    public void Ejecutar(int id){
        repositorio.delete(id);
    }

}