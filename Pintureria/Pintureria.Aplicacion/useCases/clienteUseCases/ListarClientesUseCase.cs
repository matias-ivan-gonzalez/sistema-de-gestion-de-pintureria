namespace Pintureria.Aplicacion;

public class ListarClientesUseCase : ClienteUseCase{

    public ListarClientesUseCase(IRepositorioCliente repositorio) : base(repositorio){}
    
    public void Ejecutar(int id){
        repositorio.get();
    }
}