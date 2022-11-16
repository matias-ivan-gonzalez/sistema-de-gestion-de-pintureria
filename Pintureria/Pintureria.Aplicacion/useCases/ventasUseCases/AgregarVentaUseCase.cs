namespace Pintureria.Aplicacion;

public class AgregarVentaUseCase : VentaUseCase{

    public AgregarVentaUseCase(IRepositorio<Venta> repositorio) : base(repositorio){}

    public void Ejecutar(Venta venta){
        repositorio.add(venta);
    }

}