public class DetalleVenta : Entidad, ICloneable {
    public long VentaId {get; set;}

    public long ProductoId {get; protected set;}

    public int Cantidad {get; set;}

    public double PrecioUnidad {get; set;}
    

    public DetalleVenta(int cant, double precio, long idVenta, long idProducto){
        VentaId = idVenta; ProductoId = idProducto;
        PrecioUnidad = precio;
        Cantidad = cant;
    }

    public DetalleVenta(int cant, double precio, long idProducto){
        PrecioUnidad = precio;
        Cantidad = cant;
    }

    private DetalleVenta() : base(){}

    public override string ToString(){
        return $"Cantidad: {Cantidad} Precio Unidad: {PrecioUnidad}";
    }

    object ICloneable.Clone()
    {
        throw new NotImplementedException();
    }
}