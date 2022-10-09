namespace Pintureria.Aplicacion;

public class ListarClientesUseCase{

    private readonly IRepositorioCliente repositorio;

    public ListarClientesUseCase(IRepositorioCliente unRepositorio){
        repositorio = unRepositorio;
    }
    
    public void Ejecutar(int id){
        repositorio.get();
    }
}