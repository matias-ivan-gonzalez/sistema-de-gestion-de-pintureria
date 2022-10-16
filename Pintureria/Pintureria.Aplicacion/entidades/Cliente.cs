using System.Security.Cryptography;
namespace Pintureria.Aplicacion;
using System.Text;


public abstract class Cliente {
    public string Id {get;protected set;}
    public string? Nombre {get;set;}
    public string? Direccion {get; set;}
    public string? Telefono {get; set;}

    protected Cliente(string str){
        Id = GetMD5(str);
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

    protected static string GetMD5(string str){
        MD5 md5 = MD5.Create();
        ASCIIEncoding encoding = new ASCIIEncoding();
        byte[]? stream = null;
        StringBuilder sb = new StringBuilder();
        stream = md5.ComputeHash(encoding.GetBytes(str));
        for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
        return sb.ToString();
    }
}
