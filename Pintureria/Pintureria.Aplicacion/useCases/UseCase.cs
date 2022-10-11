namespace Pintureria.Aplicacion;

public class UseCase{
    protected readonly IRepositorio repositorio;
    public UseCase(IRepositorio unRepositorio){
        repositorio = unRepositorio;
    }
}