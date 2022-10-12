namespace Pintureria.Aplicacion;
using System.Text;
public class ClienteEmpresa : Cliente {

    public string? CUIT {get;set;}
    public string? SitioWeb {get;set;}
    
    // public ClienteEmpresa(string nombre, string direccion, string telefono, string cuit)
    //                      :base(nombre, direccion, telefono){
    //     Cuit = cuit;
    // }
    public ClienteEmpresa() : base(){}

    public override string ToString(){
        StringBuilder sb = new StringBuilder();
        sb.Append(base.ToString());
        sb.Append($" {CUIT}");
        sb.Append($" {SitioWeb}");
        return sb.ToString();
    }
}