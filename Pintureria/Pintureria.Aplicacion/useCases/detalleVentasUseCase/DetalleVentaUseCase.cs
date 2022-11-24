namespace Pintureria.Aplicacion;

public class DetalleVentaUseCase{
    protected readonly IRepositorio<DetalleVenta> repositorio;
    public DetalleVentaUseCase(IRepositorio<DetalleVenta> unRepositorio){
        repositorio = unRepositorio;
    }
}