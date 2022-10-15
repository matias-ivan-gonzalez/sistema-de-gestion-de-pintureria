namespace Pintureria.Aplicacion;

public class ListarProductosUseCase : ProductoUseCase{

    public ListarProductosUseCase(IRepositorioProducto repositorio) : base(repositorio){}

    public List<String> Ejecutar(){
        return repositorio.get();
    }

}