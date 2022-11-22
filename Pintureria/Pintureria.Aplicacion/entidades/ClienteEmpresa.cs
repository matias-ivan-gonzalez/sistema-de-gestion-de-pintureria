namespace Pintureria.Aplicacion;
using System.Text;
public class ClienteEmpresa : Cliente, ICloneable {

    public long CUIT {get;set;}
    public string? SitioWeb {get;set;}
    
    public ClienteEmpresa(long cuit) : base(cuit) {
        this.CUIT = cuit;
    }

    private ClienteEmpresa() : base(){}

    public override string ToString(){
        StringBuilder sb = new StringBuilder();
        sb.Append(base.ToString());
        sb.Append($"CUIT: {CUIT} ");
        sb.Append($"SitioWeb: {SitioWeb} ");
        return sb.ToString();
    }

    object ICloneable.Clone()
    {
        return new ClienteEmpresa(){
            Id = this.Id,
            Nombre = this.Nombre,
            Direccion = this.Direccion,
            Telefono = this.Telefono,
            CUIT = this.CUIT,
            SitioWeb = this.SitioWeb
        };
    }
}