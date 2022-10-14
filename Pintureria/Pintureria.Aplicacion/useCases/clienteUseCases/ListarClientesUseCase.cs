namespace Pintureria.Aplicacion;

public class ListarClientesUseCase : ClienteUseCase{

    public ListarClientesUseCase(IRepositorioCliente repositorio) : base(repositorio){}
    
    public List<String?> Ejecutar(){
        return repositorio.get();
    }
}