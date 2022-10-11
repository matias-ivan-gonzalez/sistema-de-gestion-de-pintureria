namespace Pintureria.Aplicacion;

public class EliminarClienteUseCase : UseCase{

    public EliminarClienteUseCase(IRepositorioCliente repositorio) : base(repositorio){}

    public void Ejecutar(int id){
        try{
            repositorio.delete(id);   
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }
}