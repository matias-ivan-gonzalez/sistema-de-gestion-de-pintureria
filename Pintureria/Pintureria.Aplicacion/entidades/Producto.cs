namespace Pintureria.Aplicacion;

public class Producto {
    public string Id {get;}
    public string? Descripcion {get; set;}
    public double PrecioUnitario {get;set;}
    public int Stock {get; set;}

    public Producto(){
       Id = Guid.NewGuid().ToString();
    }

    public override string ToString(){
        return $"ID: {Id} Descripcion: {Descripcion} PrecioUnitario: {PrecioUnitario} Stock: {Stock}";
    }
}