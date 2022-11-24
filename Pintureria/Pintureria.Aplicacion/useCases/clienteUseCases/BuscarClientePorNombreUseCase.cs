namespace Pintureria.Aplicacion;

public class BuscarClientePorNombreUseCase : ClienteUseCase{

    public BuscarClientePorNombreUseCase(IRepositorio<Cliente> repositorio) : base(repositorio){}
    
    public Cliente? Ejecutar(string name){
        return repositorio.getSpecificUserByName(name);
    }
}