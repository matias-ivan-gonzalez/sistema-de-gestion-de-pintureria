namespace Pintureria.Aplicacion;

public class ModificarClienteUseCase : UseCase{

    public ModificarClienteUseCase(IRepositorioCliente repositorio) : base(repositorio){}
    
    public void Ejecutar(Cliente cli){
        try{
            repositorio.modify(cli);    
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }
}