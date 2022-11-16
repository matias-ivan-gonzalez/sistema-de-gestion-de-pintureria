namespace Pintureria.Aplicacion;
public interface IRepositorio<T> where T: Entidad {
    public void add(T entidad);
    public void modify(T entidad);
    public void delete(long id);
    public List<T> get();
}