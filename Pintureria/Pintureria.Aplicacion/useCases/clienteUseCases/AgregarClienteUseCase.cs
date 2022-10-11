namespace Pintureria.Aplicacion;

public class AgregarClienteUseCase : UseCase{

    public AgregarClienteUseCase(IRepositorioCliente repositorio) : base(repositorio){}
    
    public void Ejecutar(Cliente cli){
        repositorio.add(cli);
    }
}