namespace Pintureria.Aplicacion;

public class BuscarClientesQueCompraronEsteAñoUseCase : VentaUseCase{

    private IRepositorio<Cliente> RepositorioCliente;

    public BuscarClientesQueCompraronEsteAñoUseCase(IRepositorio<Cliente> repositorioCliente, IRepositorio<Venta> repositorio) : base(repositorio){
        this.RepositorioCliente = repositorioCliente;
    }

    public List<Cliente> Ejecutar(){
        List<long> idsClientes = repositorio.get().Where(v => v.Fecha.Year == DateTime.Now.Year).Select(v => v.Cliente).ToList<long>();
        return RepositorioCliente.get().Where(c => idsClientes.Contains(c.Id)).ToList<Cliente>();
    }

}