namespace Pintureria.Aplicacion;
public interface IRepositorio{
    public bool add(Object o);
    public bool modify(Object o);
    public bool delete(int id);
    public bool get();
}