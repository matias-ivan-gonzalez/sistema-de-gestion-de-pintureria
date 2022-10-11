namespace Pintureria.Aplicacion;

public class EliminarProductoUseCase : UseCase{

    public EliminarProductoUseCase(IRepositorioProducto repositorio) : base(repositorio){}

    public void Ejecutar(int id){
        repositorio.delete(id);
    }

}