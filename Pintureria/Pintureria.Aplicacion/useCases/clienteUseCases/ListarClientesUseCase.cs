namespace Pintureria.Aplicacion;

public class ListarClientesUseCase : ClienteUseCase{

    public ListarClientesUseCase(IRepositorio<Cliente> repositorio) : base(repositorio){}
    
    public List<Cliente> Ejecutar(){
        return repositorio.get();
    }
}