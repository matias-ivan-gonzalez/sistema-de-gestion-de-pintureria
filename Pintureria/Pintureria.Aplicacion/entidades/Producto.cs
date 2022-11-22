namespace Pintureria.Aplicacion;

public class Producto : Entidad, ICloneable {
    public string? Descripcion {get; set;}
    public double PrecioUnitario {get;set;}
    public long Stock {get;set;}

    public Producto(string descripcion) : base(){
        Descripcion = descripcion;
    }

    public Producto() : base(){}

    public override string ToString(){
        return $"ID: {Id} Descripcion: {Descripcion} PrecioUnitario: {PrecioUnitario} Stock: {Stock}";
    }

    object ICloneable.Clone()
    {
        return new Producto(){
            Id = this.Id,
            Descripcion = this.Descripcion,
            PrecioUnitario = this.PrecioUnitario,
            Stock = this.Stock
        };
    }
}