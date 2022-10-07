namespace Pintureria.Aplicacion;

public class Producto {
    static int s_id = 0;
    public int Id {get;}
    public string Descripcion {get; set;}
    public double PrecioUnitario {get;set;}
    public int Stock {get => Stock ; 
                     set { Stock = (value < 0) ? 0 : value;}}

    public Producto(string descripcion, double precio, int stock){
        s_id++;
        Id = s_id;
        Descripcion = descripcion;
        PrecioUnitario = precio;
        Stock = stock;
    }
}