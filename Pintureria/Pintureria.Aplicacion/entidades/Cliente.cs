namespace Pintureria.Aplicacion;
using System.Text;
using Pintureria.Aplicacion.helpers;

public abstract class Cliente {
    public string Id {get;protected set;}
    public string? Nombre {get;set;}
    public string? Direccion {get; set;}
    public string? Telefono {get; set;}

    protected Cliente(string str){
        Id = HashHelper.GetMD5(str);
    }

    public override string ToString(){
        StringBuilder sb = new StringBuilder();
        sb.Append($"{this.GetType()} ");
        sb.Append($"ID: {Id} ");
        sb.Append($"Nombre: {Nombre} ");
        sb.Append($"Direccion: {Direccion} ");
        sb.Append($"Telefono: {Telefono} ");
        return sb.ToString();
    }

}
