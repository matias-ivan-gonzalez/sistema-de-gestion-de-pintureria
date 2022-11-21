namespace Pintureria.Aplicacion;

public class ModificarProductoUseCase : ProductoUseCase{

    public ModificarProductoUseCase(IRepositorio<Producto> repositorio) : base(repositorio){}

    public void Ejecutar(Producto producto){
        try{
            if(producto.PrecioUnitario < 0 || producto.Stock < 0){
                throw new NegativeValueNotAllowedException();
            }
            else{
                repositorio.modify(producto);
            }
        }
        catch(NegativeValueNotAllowedException e){
            Console.WriteLine(e.Message);
        }
    }

}