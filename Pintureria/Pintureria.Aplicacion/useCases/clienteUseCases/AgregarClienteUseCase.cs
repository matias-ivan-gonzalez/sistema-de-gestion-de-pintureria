namespace Pintureria.Aplicacion;

public class AgregarClienteUseCase : ClienteUseCase{

    public AgregarClienteUseCase(IRepositorioCliente repositorio) : base(repositorio){}
    
    public void Ejecutar(Cliente cli){
        repositorio.add(cli);
    }
}