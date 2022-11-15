namespace Pintureria.Aplicacion;

public class ClienteUseCase{
    protected readonly IRepositorio<Cliente> repositorio;
    public ClienteUseCase(IRepositorio<Cliente> unRepositorio){
        repositorio = unRepositorio;
    }
}