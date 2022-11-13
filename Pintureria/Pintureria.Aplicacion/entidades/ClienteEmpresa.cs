using System.Security.Cryptography;
namespace Pintureria.Aplicacion;
using System.Text;
public class ClienteEmpresa : Cliente {

    public long CUIT {get;set;}
    public string? SitioWeb {get;set;}
    
    public ClienteEmpresa(long cuit) : base(cuit) {
        this.CUIT = cuit;
    }

    public ClienteEmpresa() {
    }

    public override string ToString(){
        StringBuilder sb = new StringBuilder();
        sb.Append(base.ToString());
        sb.Append($"CUIT: {CUIT} ");
        sb.Append($"SitioWeb: {SitioWeb} ");
        return sb.ToString();
    }

    
}