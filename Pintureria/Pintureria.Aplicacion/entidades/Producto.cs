namespace Pintureria.Aplicacion;

public class Producto {
    private int _stock;
    public string Id {get;}
    public string? Descripcion {get; set;}
    public double PrecioUnitario {get;set;}
    public int Stock {get => _stock; 
                      set => _stock = (value < 0) ? 0 : value;}

    public Producto(){
       Id = Guid.NewGuid().ToString();
    }

    public override string ToString(){
        return $"ID: {Id} Descripcion: {Descripcion} PrecioUnitario: {PrecioUnitario} Stock: {Stock}";
    }
}