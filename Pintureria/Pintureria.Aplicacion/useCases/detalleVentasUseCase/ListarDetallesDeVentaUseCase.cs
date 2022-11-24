namespace Pintureria.Aplicacion;

public class ListarDetallesDeVentaUseCase : DetalleVentaUseCase {

    public ListarDetallesDeVentaUseCase(IRepositorio<DetalleVenta> repositorio) : base(repositorio){}

    public List<DetalleVenta> Ejecutar(long idVenta){
        return repositorio.get().Where(dv => dv.VentaId == idVenta).ToList<DetalleVenta>();
    }

}