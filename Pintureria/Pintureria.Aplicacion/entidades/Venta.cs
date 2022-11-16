namespace Pintureria.Aplicacion;

public class Venta: Entidad{
    public int Id {get; private set;}
    public int Cliente {get;}
    public DateTime Fecha {get; private set;}
    public double MontoTotal {get; private set;}

    public IEnumerable<DetalleVenta> Detalles {get; private set;}

    public Venta(IEnumerable<DetalleVenta> lista){
        Detalles = lista;
        Fecha = DateTime.Now;
        MontoTotal = this.calcularMonto(Detalles);
    }

    private double calcularMonto(IEnumerable<DetalleVenta> detalles) => detalles.ToList().Sum(n => n.cantidad * n.precioUnidad);


}