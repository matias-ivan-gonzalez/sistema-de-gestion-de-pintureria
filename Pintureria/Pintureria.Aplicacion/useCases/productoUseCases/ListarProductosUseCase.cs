namespace Pintureria.Aplicacion;

public class ListarProductosUseCase : ProductoUseCase{

    public ListarProductosUseCase(IRepositorio<Producto> repositorio) : base(repositorio){}

    public List<Producto> Ejecutar(){
        return repositorio.get();
    }

}