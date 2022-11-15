namespace Pintureria.Aplicacion;

public class EliminarClienteUseCase : ClienteUseCase{

    public EliminarClienteUseCase(IRepositorio<Cliente> repositorio) : base(repositorio){}

    public void Ejecutar(long id){
        repositorio.delete(id);
    }
}