namespace Pintureria.Aplicacion;
using System.Text;
using Pintureria.Aplicacion.helpers;

public abstract class Cliente : Entidad{
    public string? Nombre {get;set;}
    public string? Direccion {get; set;}
    public string? Telefono {get; set;}

    protected Cliente(long id) : base(id){}

    protected Cliente() : base(){}

    public override string ToString(){
        StringBuilder sb = new StringBuilder();
        sb.Append($"{this.GetType().Name} ");
        sb.Append($"ID: {Id} ");
        sb.Append($"Nombre: {Nombre} ");
        sb.Append($"Direccion: {Direccion} ");
        sb.Append($"Telefono: {Telefono} ");
        return sb.ToString();
    }

}
