namespace Pintureria.Aplicacion;

public class BuscarVentaUseCase : VentaUseCase{

    public BuscarVentaUseCase(IRepositorio<Venta> repositorio) : base(repositorio){}

    public Venta? Ejecutar(long id){
        return repositorio.getSpecificRecord(id);
    }

}