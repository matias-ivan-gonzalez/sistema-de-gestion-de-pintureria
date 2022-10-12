namespace Pintureria.Aplicacion;
using System.Text;
public class ClienteFisico : Cliente {

    public int? DNI {get;set;}

    // public ClienteFisico(string nombre, string direccion, string telefono, string dni)
    //                      :base(nombre, direccion, telefono){
    //     Dni = dni;
    // }

    public ClienteFisico() : base(){}

    public override string ToString(){
        StringBuilder sb = new StringBuilder();
        sb.Append(base.ToString());
        sb.Append($" {DNI}");
        return sb.ToString();
    }
}