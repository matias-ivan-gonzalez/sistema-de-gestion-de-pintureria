namespace Pintureria.Aplicacion;

public class AgregarClienteUseCase : ClienteUseCase{

    public AgregarClienteUseCase(IRepositorio<Cliente> repositorio) : base(repositorio){}
    
    public void Ejecutar(Cliente cli){
        try{
            List<Cliente> clientes = repositorio.get();
            if(repositorio.get().Contains(cli)) throw new AlreadyRegisteredException();
            repositorio.add(cli); 
        }
        catch (System.Exception){
            
            throw;
        }
    }
}