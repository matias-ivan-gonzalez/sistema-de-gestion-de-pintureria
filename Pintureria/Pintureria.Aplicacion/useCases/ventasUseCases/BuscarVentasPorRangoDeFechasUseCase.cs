namespace Pintureria.Aplicacion;

public class BuscarVentasPorRangoDeFechasUseCase : VentaUseCase{

    public BuscarVentasPorRangoDeFechasUseCase(IRepositorio<Venta> repositorio) : base(repositorio){}

    public List<Venta> Ejecutar(DateTime from, DateTime to){
        return repositorio.get().Where(v => v.Fecha >= from.Date && v.Fecha <= to.Date).ToList<Venta>();
    }

}