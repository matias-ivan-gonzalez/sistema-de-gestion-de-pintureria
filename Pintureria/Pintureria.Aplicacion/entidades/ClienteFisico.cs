namespace Pintureria.Aplicacion;
using System.Text;
public class ClienteFisico : Cliente {

    public int DNI {get;set;}

    public ClienteFisico(int dni) : base(dni){
        DNI = dni;
    }

    public ClienteFisico() {
    }

    public override string ToString(){
        StringBuilder sb = new StringBuilder();
        sb.Append(base.ToString());
        sb.Append($"DNI: {DNI} ");
        return sb.ToString();
    }
}