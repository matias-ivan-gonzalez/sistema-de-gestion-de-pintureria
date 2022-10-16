using Pintureria.Aplicacion;
using Pintureria.Repositorios;

var repoCliente = new RepositorioClienteTXT();
var agregarCliente = new AgregarClienteUseCase(repoCliente);
var listarClientes = new ListarClientesUseCase(repoCliente);
var eliminarCliente = new EliminarClienteUseCase(repoCliente);
var modificarCliente = new ModificarClienteUseCase(repoCliente);
var persona1 = new ClienteFisico()
{
    Nombre = "juan",
    Direccion = "Diag.74 nro 123",
    Telefono = "(11)502-1111",
    DNI = 30321654
};
var empresa = new ClienteEmpresa()
{
    Nombre = "Empresa SA",
    Direccion = "calle 13 nro. 123",
    Telefono = "(221)543-3456",
    CUIT = "30-12345678-1",
    SitioWeb = "www.empresaSA.com"
};

var persona2 = new ClienteFisico()
{
    Nombre = "María",
    Direccion = "calle 5 nro 1544",
    Telefono = "(221)501-9999",
    DNI = 22752412
};
Console.WriteLine("\nCarga de clientes");
agregarCliente.Ejecutar(persona1);
agregarCliente.Ejecutar(empresa);
agregarCliente.Ejecutar(persona2);
listarEnConsola();
Console.WriteLine("\nModificacion de clientes");
persona2.Nombre = "Claudia";
empresa.Direccion = "calle 7 nro. 50";
modificarCliente.Ejecutar(persona2);
modificarCliente.Ejecutar(empresa);
modificarCliente.Ejecutar(empresa);
listarEnConsola();
Console.WriteLine("\nEliminacion de clientes");
eliminarCliente.Ejecutar(1);
Console.WriteLine("\nListado de clientes");
listarEnConsola();

void listarEnConsola()
{
    var lista = listarClientes.Ejecutar();
    foreach (var c in lista)
    {
        Console.WriteLine(c);
    }
    Console.WriteLine("-----");
}
Console.WriteLine("\n\n");


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/* Producto */

var repoProducto = new RepositorioProductoTXT();
var agregarProducto = new AgregarProductoUseCase(repoProducto);
var listarProductos = new ListarProductosUseCase(repoProducto);
var eliminarProducto = new EliminarProductoUseCase(repoProducto);
var modificarProducto = new ModificarProductoUseCase(repoProducto);

Producto producto1 = new Producto()
{
    Descripcion = "Balde Pintura Amarilla 3L",
    PrecioUnitario = 530.00,
    Stock = 30
};

Producto producto2 = new Producto()
{
    Descripcion = "Balde Pintura Blanca 3L",
    PrecioUnitario = 870.00,
    Stock = 40
};

Producto producto3 = new Producto()
{
    Descripcion = "Rodillo grande ",
    PrecioUnitario = 1200.00,
    Stock = 10
};

Producto producto4 = new Producto()
{
    Descripcion = "Pincel para interiores",
    PrecioUnitario = 610.00,
    Stock = 15
};

Producto producto5 = new Producto()
{
    Descripcion = "Lija fina 180",
    PrecioUnitario = 150.00,
    Stock = 50
};
Console.WriteLine("\nCarga de productos");
agregarProducto.Ejecutar(producto1);
agregarProducto.Ejecutar(producto2);
agregarProducto.Ejecutar(producto3);
agregarProducto.Ejecutar(producto4);
agregarProducto.Ejecutar(producto5);
listarProductosEnConsola();
Console.WriteLine("\nModificacion de productos");
producto3.PrecioUnitario = 930.50;
producto3.Descripcion = "Balde Pintura Blanca 3.5L";
producto3.Stock = 8;

producto5.PrecioUnitario = 165.00;
producto5.Stock = 200;

modificarProducto.Ejecutar(producto3);
modificarProducto.Ejecutar(producto5);
listarProductosEnConsola();
Console.WriteLine("\nEliminacion de productos");
eliminarProducto.Ejecutar(2);
Console.WriteLine("\nListado de productos");
listarProductosEnConsola();


void listarProductosEnConsola()
{
    var lista = listarProductos.Ejecutar();
    foreach (var p in lista)
    {
        Console.WriteLine(p);
    }
    Console.WriteLine("-----");
}

Console.ReadLine();
//FileHelper.resetearArchivos();