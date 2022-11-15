namespace Pintureria.Aplicacion;
public interface IRepositorio<T> where T: Entidad {
    public void add(T cli);
    public void modify(T cli);
    public void delete(long id);
    public List<T> get();
}