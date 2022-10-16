namespace Pintureria.Aplicacion;
using Pintureria.Aplicacion.helpers;

public class Producto {
    private int _stock;
    public string Id {get;}
    public string Descripcion {get;}
    public double PrecioUnitario {get;set;}
    public int Stock {get => _stock; 
                      set => _stock = (value < 0) ? 0 : value;}

    public Producto(string descripcion){
        Descripcion = descripcion;
        Id = HashHelper.GetMD5(descripcion);
    }

    public override string ToString(){
        return $"ID: {Id} Descripcion: {Descripcion} PrecioUnitario: {PrecioUnitario} Stock: {Stock}";
    }
}