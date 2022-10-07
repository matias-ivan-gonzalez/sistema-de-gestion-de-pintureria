namespace Pintureria.Aplicacion;
public class ClienteEmpresa:Cliente {

    public string Cuit {get;}
    public string? Url {get; set;}
    
    public ClienteEmpresa(string nombre, string direccion, string telefono, string cuit)
                         :base(nombre, direccion, telefono){
        Cuit = cuit;
    }
}