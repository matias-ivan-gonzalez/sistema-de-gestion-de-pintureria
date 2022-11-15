namespace Pintureria.Aplicacion;

public class AgregarClienteUseCase : ClienteUseCase{

    public AgregarClienteUseCase(IRepositorio<Cliente> repositorio) : base(repositorio){}
    
    public void Ejecutar(Cliente cli){
        repositorio.add(cli);
    }
}