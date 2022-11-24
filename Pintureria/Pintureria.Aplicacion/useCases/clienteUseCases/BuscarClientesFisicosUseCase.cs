namespace Pintureria.Aplicacion;

public class BuscarClientesFisicosUseCase : ClienteUseCase<ISearcheable<Cliente>>{

    public BuscarClientesFisicosUseCase(ISearcheable<Cliente> repositorio) : base(repositorio){}
    
    public List<Cliente> Ejecutar(){
        return repositorio.obtenerClientes("ClienteFisico");
    }
}