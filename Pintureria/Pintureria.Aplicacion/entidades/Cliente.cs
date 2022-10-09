namespace Pintureria.Aplicacion;
using System.Text;
public abstract class Cliente {

    static int s_idCount = 0;
    public int Id {get;}
    public string Nombre {get;}
    public string Direccion {get; set;}
    public string Telefono {get; set;}


    // protected Cliente(){
    //     s_idCount++;
    //     Id = s_idCount;
    // }

    protected Cliente (string nombre, string direccion, string telefono ) {
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
        s_idCount++;
        Id = s_idCount;
    }

    public override string ToString(){
        StringBuilder sb = new StringBuilder();
        sb.Append(this.GetType());
        sb.Append($" {Nombre}");
        sb.Append($" {Direccion}");
        sb.Append($" {Telefono}");
        return sb.ToString();
    }
}
