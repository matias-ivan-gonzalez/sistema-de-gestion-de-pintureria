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
agregarCliente.Ejecutar(persona1);
agregarCliente.Ejecutar(empresa);
agregarCliente.Ejecutar(persona2);
listarEnConsola();
persona2.Nombre = "Claudia";
empresa.Direccion = "calle 7 nro. 50";
modificarCliente.Ejecutar(persona2);
modificarCliente.Ejecutar(empresa);
listarEnConsola();
eliminarCliente.Ejecutar(1);
listarEnConsola();
void listarEnConsola()
{
    // Listar Clientes
    var listaCli = listarClientes.Ejecutar();
    foreach (var c in listaCli)
    {
        Console.WriteLine(c);
    }
    Console.WriteLine("-----");

    // Listar Productos
    var listaProd = listarProductos.Ejecutar();
    foreach (var p in listaProd)
    {
        Console.WriteLine(p);
    }
    Console.WriteLine("-----");
}

Console.ReadLine();

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/* Producto */
var repoProducto = new RepositorioProductoTXT();
var agregarProducto = new AgregarProductoUseCase(repoProducto);
var listarClientes = new ListarClientesUseCase(repoProducto);
var eliminarProducto = new EliminarProductoUseCase(repoProducto);
var modificarProducto = new ModificarProductoUseCase(repoProducto);

Producto producto1 = new Producto()
{
    Descipcion = "Balde Pintura Amarilla 3L",
    PrecioUnitario = 530.00,
    Stock = 30
};

Producto producto2 = new Producto()
{
    Descipcion = "Balde Pintura Blanca 3L",
    PrecioUnitario = 870.00,
    Stock = 40
};

Producto producto3 = new Producto()
{
    Descipcion = "Rodillo grande ",
    PrecioUnitario = 1200.00,
    Stock = 10
};

Producto producto4 = new Producto()
{
    Descipcion = "Pincel para interiores",
    PrecioUnitario = 610.00,
    Stock = 15
};

Producto producto5 = new Producto()
{
    Descipcion = "Lija fina 180",
    PrecioUnitario = 150.00,
    Stock = 50
};

agregarProducto.Ejecutar(producto1);
agregarProducto.Ejecutar(producto2);
agregarProducto.Ejecutar(producto3);
agregarProducto.Ejecutar(producto4);
agregarProducto.Ejecutar(producto5);
listarEnConsola();

producto3.PrecioUnitario = 930.50;
producto3.Descipcion = "Balde Pintura Blanca 3.5L";
producto3.Stock = 8;

producto5.PrecioUnitario = 165.00;
producto5.Stock = 200;

modificarProducto.Ejecutar(producto3);
modificarProducto.Ejecutar(producto5);
listarEnConsola();

eliminarProducto.Ejecutar(2);
listarEnConsola();

Console.ReadLine();
