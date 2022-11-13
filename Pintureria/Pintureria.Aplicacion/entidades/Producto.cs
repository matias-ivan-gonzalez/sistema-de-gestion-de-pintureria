namespace Pintureria.Aplicacion;
using Pintureria.Aplicacion.helpers;


public class Producto {
    public string? Id {get; set;}
    public string? Descripcion {get;}
    public double PrecioUnitario {get;set;}
    public long Stock {get;set;}

    public Producto(string descripcion){
        Descripcion = descripcion;
        Id = HashHelper.GetMD5(descripcion);
    }

    public Producto(){
    }

    public override string ToString(){
        return $"ID: {Id} Descripcion: {Descripcion} PrecioUnitario: {PrecioUnitario} Stock: {Stock}";
    }
}