public class DetalleVenta : Entidad {
    public long VentaId {get; protected set;}

    public long ProductoId {get; protected set;}

    public int Cantidad {get; set;}

    public double PrecioUnidad {get; set;}

    public DetalleVenta(int cant, double precio, long idVenta, long idProducto){
        VentaId = idVenta; ProductoId = idProducto;
        PrecioUnidad = precio;
        Cantidad = cant;
    }

    private DetalleVenta() : base(){}

}