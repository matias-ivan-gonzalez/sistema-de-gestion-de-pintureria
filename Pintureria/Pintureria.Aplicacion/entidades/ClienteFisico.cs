namespace Pintureria.Aplicacion;
using System.Text;
public class ClienteFisico : Cliente {

    public string DNI {get;set;}

    public ClienteFisico(string dni) : base(dni){
        DNI = dni;
    }

    public override string ToString(){
        StringBuilder sb = new StringBuilder();
        sb.Append(base.ToString());
        sb.Append($"DNI: {DNI} ");
        return sb.ToString();
    }
}