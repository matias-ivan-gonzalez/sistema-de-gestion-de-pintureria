namespace Pintureria.Aplicacion;

public class ClienteUseCase<Interface>{
    protected readonly Interface repositorio;
    public ClienteUseCase(Interface unRepositorio){
        repositorio = unRepositorio;
    }
}