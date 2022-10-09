namespace Pintureria.Aplicacion;
using System.Text;
public class ClienteFisico : Cliente {

    public string Dni {get;}

    public ClienteFisico(string nombre, string direccion, string telefono, string dni)
                         :base(nombre, direccion, telefono){
        Dni = dni;
    }

    public override string ToString(){
        StringBuilder sb = new StringBuilder();
        sb.Append(base.ToString());
        sb.Append($" {Dni}");
        return sb.ToString();
    }
}