namespace Pintureria.Aplicacion;

public class ModificarClienteUseCase : ClienteUseCase{

    public ModificarClienteUseCase(IRepositorio<Cliente> repositorio) : base(repositorio){}
    
    public void Ejecutar(Cliente cli){
        try{
            repositorio.modify(cli);    
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }
}