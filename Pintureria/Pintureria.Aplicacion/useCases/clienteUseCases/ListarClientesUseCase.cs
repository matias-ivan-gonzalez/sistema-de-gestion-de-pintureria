namespace Pintureria.Aplicacion;

public class ListarClientesUseCase : ClienteUseCase{

    public ListarClientesUseCase(IRepositorioCliente repositorio) : base(repositorio){}
    
    public List<Cliente> Ejecutar(){
        //return repositorio.get();
        return new List<Cliente>();
    }
}