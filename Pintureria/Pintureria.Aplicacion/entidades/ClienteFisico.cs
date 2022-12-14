namespace Pintureria.Aplicacion;
using System.Text;
public class ClienteFisico : Cliente, ICloneable {

    public int DNI {get;set;}

    public ClienteFisico(int dni) : base(dni){
        DNI = dni;
    }

    public ClienteFisico() : base(){}


    public override string ToString(){
        StringBuilder sb = new StringBuilder();
        sb.Append(base.ToString());
        sb.Append($"DNI: {DNI} ");
        return sb.ToString();
    }

    object ICloneable.Clone()
    {
        return new ClienteFisico(){
            Id = this.Id,
            Nombre = this.Nombre,
            Direccion = this.Direccion,
            Telefono = this.Telefono,
            DNI = this.DNI        
        };
    }
}