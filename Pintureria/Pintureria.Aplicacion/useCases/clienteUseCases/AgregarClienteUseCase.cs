namespace Pintureria.Aplicacion;

public class AgregarClienteUseCase{

    private readonly IRepositorioCliente repositorio;

    public AgregarClienteUseCase(IRepositorioCliente unRepositorio){
        repositorio = unRepositorio;
    }
    
    public void Ejecutar(Cliente cli){
        repositorio.add(cli);
    }
}