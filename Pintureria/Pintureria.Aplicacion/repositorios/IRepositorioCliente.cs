namespace Pintureria.Aplicacion;
public interface IRepositorioCliente : IRepositorio{
    public bool add(Cliente cli);
    public bool modify(Cliente cli);
}