namespace Pintureria.Aplicacion;

public class ModificarClienteUseCase{

    private readonly IRepositorioCliente repositorio;

    public ModificarClienteUseCase(IRepositorioCliente unRepositorio){
        repositorio = unRepositorio;
    }
    
    public void Ejecutar(Cliente cli){
        try{
            repositorio.modify(cli);    
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }
}