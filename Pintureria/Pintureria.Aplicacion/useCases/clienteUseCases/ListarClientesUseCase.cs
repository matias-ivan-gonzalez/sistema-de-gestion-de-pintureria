namespace Pintureria.Aplicacion;

public class ListarClientesUseCase : ClienteUseCase<IRepositorio<Cliente>>{

    public ListarClientesUseCase(IRepositorio<Cliente> repositorio) : base(repositorio){}
    
    public List<Cliente> Ejecutar(){
        return repositorio.get();
    }
}