namespace Pintureria.Aplicacion;

public class AgregarClienteUseCase : ClienteUseCase<IRepositorio<Cliente>>{

    public AgregarClienteUseCase(IRepositorio<Cliente> repositorio) : base(repositorio){}
    
    public void Ejecutar(Cliente cli){
        repositorio.add(cli);
    }
}