namespace Pintureria.Aplicacion;

public class ListarVentasUseCase : VentaUseCase{

    public ListarVentasUseCase(IRepositorio<Venta> repositorio) : base(repositorio){}

    public List<Venta> Ejecutar(){
        return repositorio.get();
    }

}