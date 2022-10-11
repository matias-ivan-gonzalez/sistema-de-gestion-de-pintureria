namespace Pintureria.Aplicacion;

public class ListarClientesUseCase : UseCase{

    public ListarClientesUseCase(IRepositorioCliente repositorio) : base(repositorio){}
    
    public void Ejecutar(int id){
        repositorio.get();
    }
}