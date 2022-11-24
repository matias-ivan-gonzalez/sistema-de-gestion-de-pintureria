namespace Pintureria.Aplicacion;

public class BuscarClienteUseCase : ClienteUseCase{

    public BuscarClienteUseCase(IRepositorio<Cliente> repositorio) : base(repositorio){}
    
    public Cliente? Ejecutar(long id){
        return repositorio.getSpecificRecord(id);
    }
}