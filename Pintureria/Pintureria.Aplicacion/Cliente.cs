namespace Pintureria.Aplicacion;
public abstract class Cliente {

    static int s_idCount = 0;
    public int Id {get;}
    public string Nombre {get;}
    public string Direccion {get; set;}
    public string Telefono {get; set;}

    protected Cliente (string nombre, string direccion, string telefono ) {
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
        s_idCount++;
        Id = s_idCount;
    }

    





}
