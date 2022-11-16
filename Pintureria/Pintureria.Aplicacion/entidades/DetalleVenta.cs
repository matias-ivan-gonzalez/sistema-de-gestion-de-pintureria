public class DetalleVenta{
    public int IdVenta {get; protected set;}

    public int IdProducto {get; protected set;}

    public int cantidad {get; set;}

    public double precioUnidad {get; set;}

    public DetalleVenta(int cant, double precio, int idVenta, int idProducto){
        IdVenta = idVenta; IdProducto = idProducto;
        precioUnidad = precio;
        cantidad = cant;
    }

    

}