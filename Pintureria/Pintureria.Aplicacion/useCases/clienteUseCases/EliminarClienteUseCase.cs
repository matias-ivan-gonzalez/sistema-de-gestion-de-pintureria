namespace Pintureria.Aplicacion;

public class EliminarClienteUseCase : ClienteUseCase{

    public EliminarClienteUseCase(IRepositorioCliente repositorio) : base(repositorio){}

    public void Ejecutar(int id){
        repositorio.delete(id);
    }
}