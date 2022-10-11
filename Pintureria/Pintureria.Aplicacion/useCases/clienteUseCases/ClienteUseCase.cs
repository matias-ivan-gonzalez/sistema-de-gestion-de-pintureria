namespace Pintureria.Aplicacion;

public class ClienteUseCase{
    protected readonly IRepositorioCliente repositorio;
    public ClienteUseCase(IRepositorioCliente unRepositorio){
        repositorio = unRepositorio;
    }
}