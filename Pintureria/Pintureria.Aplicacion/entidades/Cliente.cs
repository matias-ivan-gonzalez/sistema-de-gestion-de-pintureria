namespace Pintureria.Aplicacion;
using System.Text;

public abstract class Cliente : Entidad, ICloneable{
    public string? Nombre {get;set;}
    public string? Direccion {get; set;}
    public string? Telefono {get; set;}

    public string? Discriminator {get; set;}

    protected Cliente(long id) : base(id){}

    protected Cliente() : base(){}

    public override string ToString(){
        StringBuilder sb = new StringBuilder();
        sb.Append($"{this.GetType().Name} ");
        sb.Append($"ID: {Id} ");
        sb.Append($"Nombre: {Nombre} ");
        sb.Append($"Direccion: {Direccion} ");
        sb.Append($"Telefono: {Telefono} ");
        return sb.ToString();
    }

    object ICloneable.Clone()
    {
        throw new NotImplementedException();
    }
}
