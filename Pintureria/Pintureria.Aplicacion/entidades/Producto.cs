namespace Pintureria.Aplicacion;
using Pintureria.Aplicacion.helpers;


public class Producto : Entidad {
    public string Descripcion {get; set;}
    public double PrecioUnitario {get;set;}
    public long Stock {get;set;}

    public Producto(string descripcion) : base(1){
        Descripcion = descripcion;
    }

    public override string ToString(){
        return $"ID: {Id} Descripcion: {Descripcion} PrecioUnitario: {PrecioUnitario} Stock: {Stock}";
    }
}