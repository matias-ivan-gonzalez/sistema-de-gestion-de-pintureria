namespace Pintureria.Aplicacion;
using System.Text;
public class ClienteEmpresa:Cliente {

    public string Cuit {get;}
    public string? Url {get; set;}
    
    public ClienteEmpresa(string nombre, string direccion, string telefono, string cuit)
                         :base(nombre, direccion, telefono){
        Cuit = cuit;
    }

    public override string ToString(){
        StringBuilder sb = new StringBuilder();
        sb.Append(base.ToString());
        sb.Append($" {Cuit}");
        sb.Append($" {Url}");
        return sb.ToString();
    }
}