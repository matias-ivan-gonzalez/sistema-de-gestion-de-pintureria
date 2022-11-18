namespace Pintureria.Aplicacion;

public class Venta: Entidad{
    public long Cliente {get;}
    public DateTime Fecha {get; private set;}
    public double MontoTotal {get; private set;}

    public IEnumerable<DetalleVenta>? Detalles {get; private set;}

    public Venta(IEnumerable<DetalleVenta> lista){
        Detalles = lista;
        Fecha = DateTime.Now;
        MontoTotal = this.calcularMonto(Detalles);
    }

    private Venta() : base(){}

    private double calcularMonto(IEnumerable<DetalleVenta> detalles) => detalles.ToList().Sum(n => n.Cantidad * n.PrecioUnidad);

    public override string ToString(){
        return $"ID: {Id} Cliente: {Cliente} Fecha: {Fecha} MontoTotal: {MontoTotal}";
    }


}