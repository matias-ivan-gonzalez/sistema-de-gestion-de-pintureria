using System.Security.Cryptography;
namespace Pintureria.Aplicacion;
using System.Text;


public abstract class Cliente {
    public string Id {get;}
    public string? Nombre {get;set;}
    public string? Direccion {get; set;}
    public string? Telefono {get; set;}

    protected Cliente(){
        Id = Guid.NewGuid().ToString();
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
