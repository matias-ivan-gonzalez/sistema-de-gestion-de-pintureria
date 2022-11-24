namespace Pintureria.Aplicacion;

public class BuscarProductoUseCase : ProductoUseCase{

    public BuscarProductoUseCase(IRepositorio<Producto> repositorio) : base(repositorio){}

    public Producto? Ejecutar(long id){
        return repositorio.getSpecificRecord(id);
    }

}