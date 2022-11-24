namespace Pintureria.Aplicacion;

public class Venta: Entidad, ICloneable{
    public long Cliente {get; private set;}
    public DateTime Fecha {get; private set;}
    public double MontoTotal {get; private set;}
    public IEnumerable<DetalleVenta>? Detalles {get; set;}

    public Venta(IEnumerable<DetalleVenta> lista){
        Detalles = lista;
        Fecha = DateTime.Now.Date;
        MontoTotal = this.calcularMonto(Detalles);
    }

    public Venta() : base(){}

    private double calcularMonto(IEnumerable<DetalleVenta> detalles) => detalles.ToList().Sum(n => n.Cantidad * n.PrecioUnidad);

    public override string ToString(){
        return $"ID: {Id} Cliente: {Cliente} Fecha: {Fecha} MontoTotal: {MontoTotal}";
    }

    object ICloneable.Clone()
    {
        return new Venta(){
            Id = this.Id,
            Cliente = this.Cliente,
            Fecha = this.Fecha,
            MontoTotal = this.MontoTotal,
            Detalles = this.Detalles,
        };
    }
}