namespace Pintureria.Aplicacion;

public class AgregarVentaUseCase : VentaUseCase{

    public AgregarVentaUseCase(IRepositorio<Venta> repositorio) : base(repositorio){}

    public void Ejecutar(Venta venta){
        try{
            if(venta.MontoTotal < 0) throw new NegativeValueNotAllowedException();
            repositorio.add(venta);
        }
        catch(NegativeValueNotAllowedException e){
            Console.WriteLine(e.Message);
        }
        repositorio.add(venta);
    }

}