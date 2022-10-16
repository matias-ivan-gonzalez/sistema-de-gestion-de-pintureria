using Pintureria.Aplicacion;
using Pintureria.Repositorios;

var repoCliente = new RepositorioClienteTXT();
var agregarCliente = new AgregarClienteUseCase(repoCliente);
var listarClientes = new ListarClientesUseCase(repoCliente);
var eliminarCliente = new EliminarClienteUseCase(repoCliente);
var modificarCliente = new ModificarClienteUseCase(repoCliente);
var persona1 = new ClienteFisico("30321654")
{
    Nombre = "juan",
    Direccion = "Diag.74 nro 123",
    Telefono = "(11)502-1111"
};
var empresa = new ClienteEmpresa("30-12345678-1")
{
    Nombre = "Empresa SA",
    Direccion = "calle 13 nro. 123",
    Telefono = "(221)543-3456",
    SitioWeb = "www.empresaSA.com"
};

var persona2 = new ClienteFisico("22752412")
{
    Nombre = "María",
    Direccion = "calle 5 nro 1544",
    Telefono = "(221)501-9999"
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
eliminarCliente.Ejecutar("1");
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

Producto producto8 = new Producto()
{
    Descripcion = "112",
    PrecioUnitario = 530.00,
    Stock = 30
};

Producto producto200 = new Producto()  // No agregar este 
{
    Descripcion = "200",
    PrecioUnitario = 200.20,
    Stock = 200
};

// Producto producto9 = new Producto()  // Con PrecioUnitario negativo
// {
//     Descripcion = "113",
//     PrecioUnitario = -12.5,
//     Stock = 30
// };
// agregarProducto.Ejecutar(producto9);

// Producto producto10 = new Producto()    // Repetido con respecto al producto9
// {
//     Descripcion = "113",
//     PrecioUnitario = -12.5,
//     Stock = 30
// };
// agregarProducto.Ejecutar(producto10);

// Producto producto11 = new Producto()       // Con Stock negativo
// {
//     Descripcion = "114",
//     PrecioUnitario = 15.5,
//     Stock = -4
// };
// agregarProducto.Ejecutar(producto11);

// Producto producto12 = new Producto()       // Con Stock negativo y precio negativo
// {
//     Descripcion = "115",
//     PrecioUnitario = -15.5,
//     Stock = -4
// };
// agregarProducto.Ejecutar(producto12);

// Producto producto13 = new Producto()       // Con Stock en double
// {
//     Descripcion = "115",
//     PrecioUnitario = 150.25,
//     Stock = 13.2
// };
// agregarProducto.Ejecutar(producto13);

// Producto producto14 = new Producto()       // Precio es un string
// {
//     Descripcion = "116",
//     PrecioUnitario = "150.25",
//     Stock = 13
// };
// agregarProducto.Ejecutar(producto14);

// Producto producto15 = new Producto()       // Sin stock por constructor
// {
//     Descripcion = "116",
//     PrecioUnitario = "150.25",
//     // Stock = 13
// };
// agregarProducto.Ejecutar(producto15);

// agregarProducto.Ejecutar(producto5);
// agregarProducto.Ejecutar(producto5);  // Producto repetido

Console.WriteLine("\nCarga de productos");
agregarProducto.Ejecutar(producto8);
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

modificarProducto.Ejecutar(producto5);


// producto2.PrecioUnitario = -15.22;  // Tipos del elemento modificado inválido
// producto2.Stock = -30 
modificarProducto.Ejecutar(producto2);

// modificarProducto.Ejecutar(producto200);  // Modificar un producto que no está agregado

// modificarProducto.Ejecutar(producto3);
// modificarProducto.Ejecutar(producto3); // Repetido

// modificarProducto


listarProductosEnConsola();

Console.WriteLine("\nEliminacion de productos");
eliminarProducto.Ejecutar(producto8.Id);


Console.WriteLine("\nListado de productos");
// eliminarProducto().Ejecutar(producto200.Id);  //Eliminar un producto que no existe
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