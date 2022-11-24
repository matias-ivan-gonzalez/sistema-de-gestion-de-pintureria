namespace Pintureria.Aplicacion;

public class AgregarClienteUseCase : ClienteUseCase{

    public AgregarClienteUseCase(IRepositorio<Cliente> repositorio) : base(repositorio){}
    
    public void Ejecutar(Cliente cli){
        try{
            repositorio.add(cli); 
        }
        catch (System.Exception){
            
            throw;
        }
    }
}