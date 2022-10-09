namespace Pintureria.Aplicacion;
public interface IRepositorioCliente{
    
    public bool add(Cliente cli);
    public bool modify(Cliente cli);
    public bool delete(int id);
    public bool get();
}