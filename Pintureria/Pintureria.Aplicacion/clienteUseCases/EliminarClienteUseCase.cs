namespace Pintureria.Aplicacion;

public class EliminarClienteUseCase{

    private readonly IRepositorioCliente repositorio;

    public EliminarClienteUseCase(IRepositorioCliente unRepositorio){
        repositorio = unRepositorio;
    }
    
    public void Ejecutar(int id){
        try{
            repositorio.delete(id);   
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }
}