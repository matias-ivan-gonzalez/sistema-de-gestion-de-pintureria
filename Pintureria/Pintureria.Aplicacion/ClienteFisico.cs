namespace Pintureria.Aplicacion;
public class ClienteFisico : Cliente {

    public string Dni {get;}

    public ClienteFisico(string nombre, string direccion, string telefono, string dni)
                         :base(nombre, direccion, telefono){
        Dni = dni;
    }
}