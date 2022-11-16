namespace Pintureria.Aplicacion;
public class VentaUseCase{
    protected readonly IRepositorio<Venta> repositorio;
    public VentaUseCase(IRepositorio<Venta> unRepositorio){
        repositorio = unRepositorio;
    }
}