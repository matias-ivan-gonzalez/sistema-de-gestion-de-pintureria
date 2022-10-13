namespace Pintureria.Aplicacion;
public interface IRepositorioCliente : IRepositorio{
    public void add(Cliente cli);
    public void modify(Cliente cli);
}