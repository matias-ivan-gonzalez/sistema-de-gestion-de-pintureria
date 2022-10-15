namespace Pintureria.Aplicacion;

public class Producto {
    static int s_id = 0;
    public int Id {get;}
    public string? Descripcion {get; set;}
    public double PrecioUnitario {get;set;}
    public int Stock {get; set;}

    public Producto(){
       s_id++;
       Id = s_id;
    }

    public override string ToString(){
        return $"ID: {Id} Descripcion: {Descripcion} PrecioUnitario: {PrecioUnitario} Stock: {Stock}";
    }
}