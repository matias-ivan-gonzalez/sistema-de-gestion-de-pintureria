namespace Pintureria.Aplicacion;

public class AgregarVentaUseCase : VentaUseCase{

    private IRepositorio<Producto> repositorioProducto;

    public AgregarVentaUseCase(IRepositorio<Producto> repositorioProducto, IRepositorio<Venta> repositorio) : base(repositorio){
        this.repositorioProducto = repositorioProducto;
    }

    public void Ejecutar(Venta venta){
        try{
            if(venta.Detalles != null){
                if(venta.MontoTotal < 0) throw new NegativeValueNotAllowedException();
                if(venta.Detalles.All(dv => repositorioProducto.getSpecificRecord(dv.ProductoId+1)?.Stock - dv.Cantidad < 0)) throw new NotEnoughStockToBuyException();
                repositorio.add(venta);
                foreach (var dv in venta.Detalles.ToList()) {
                    Producto? producto = repositorioProducto.getSpecificRecord(dv.ProductoId+1);
                    if(producto != null){
                        producto.Stock -= dv.Cantidad;
                        repositorioProducto.modify(producto);
                    }
                }
            }
        }
        catch(System.Exception e){
            Console.WriteLine(e.Message);
        }
    }

}