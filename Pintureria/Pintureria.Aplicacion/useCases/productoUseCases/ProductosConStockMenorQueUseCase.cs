namespace Pintureria.Aplicacion;

public class ProductosConStockMenorQueUseCase : ProductoUseCase{

    public ProductosConStockMenorQueUseCase (IRepositorio<Producto> repositorio) : base(repositorio){}

    public List<Producto> Ejecutar(int stockMinimo){
        return repositorio.get().Where(p => p.Stock < stockMinimo).ToList();
    }

}