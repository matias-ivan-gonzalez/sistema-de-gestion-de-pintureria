using System;
using Pintureria.Aplicacion;
using Pintureria.Repositorios;

var repoCliente = new RepositorioSqlite<Cliente>();

var agregarCliente = new AgregarClienteUseCase(repoCliente);
var listarClientes = new ListarClientesUseCase(repoCliente);
var eliminarCliente = new EliminarClienteUseCase(repoCliente);
var modificarCliente = new ModificarClienteUseCase(repoCliente);
var persona1 = new ClienteFisico(30321654)
{
    Nombre = "juan",
    Direccion = "Diag.74 nro 123",
    Telefono = "(11)502-1111"
};
var empresa = new ClienteEmpresa(30123456781)
{
    Nombre = "Empresa SA",
    Direccion = "calle 13 nro. 123",
    Telefono = "(221)543-3456",
    SitioWeb = "www.empresaSA.com"
};

var persona2 = new ClienteFisico(22752412)
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
eliminarCliente.Ejecutar(30123456781);
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

var repoProducto = new RepositorioSqlite<Producto>();
var agregarProducto = new AgregarProductoUseCase(repoProducto);
var listarProductos = new ListarProductosUseCase(repoProducto);
var eliminarProducto = new EliminarProductoUseCase(repoProducto);
var modificarProducto = new ModificarProductoUseCase(repoProducto);

Producto producto1 = new Producto("Balde Pintura Amarilla 3L")
{
    PrecioUnitario = 530.00,
    Stock = 30
};

Producto producto2 = new Producto("Balde Pintura Blanca 3L")
{
    PrecioUnitario = 870.00,
    Stock = 40
};

Producto producto3 = new Producto("Rodillo grande ")
{
    PrecioUnitario = 1200.00,
    Stock = 10
};

Producto producto4 = new Producto("Pincel para interiores")
{
    PrecioUnitario = 610.00,
    Stock = 15
};

Producto producto5 = new Producto("Lija fina 180")
{
    PrecioUnitario = 150.00,
    Stock = 50
};

Producto producto8 = new Producto("Lija fina 120")
{
    PrecioUnitario = 530.00,
    Stock = 30
};

Producto producto200 = new Producto("200")  // No agregar este 
{
    PrecioUnitario = 200.20,
    Stock = 200
};

Producto producto9 = new Producto("113")  // Con PrecioUnitario negativo - Muestra log de exception y no agrega
{
    PrecioUnitario = -12.5,
    Stock = 15
};

Producto producto10 = new Producto("112")    // Repetido con respecto al producto8 - No se agrega e informa con un log
{
    PrecioUnitario = 530.00,
    Stock = 30
};
agregarProducto.Ejecutar(producto10);

Producto producto11 = new Producto("114")       // Con Stock negativo  - Muestra log de exception y no agrega
{
    PrecioUnitario = 15.5,
    Stock = -4
};
agregarProducto.Ejecutar(producto11);

Producto producto12 = new Producto("115")       // Con Stock negativo y precio negativo - Muestra uno de los dos errores
{
    PrecioUnitario = -15.5,
    Stock = -4
};
agregarProducto.Ejecutar(producto12);

// Producto producto13 = new Producto("116")       // Con Stock en double - Error de compilación
// {
//     PrecioUnitario = 150.25,
//     Stock = 13.2
// };
// agregarProducto.Ejecutar(producto13);

// Producto producto14 = new Producto("117")       // Precio es un string - Error Compilacion
// {
//     PrecioUnitario = "150.25",
//     Stock = 13
// };
// agregarProducto.Ejecutar(producto14);

Console.WriteLine("\nCarga de productos");

agregarProducto.Ejecutar(producto8);
agregarProducto.Ejecutar(producto2);
agregarProducto.Ejecutar(producto3);
agregarProducto.Ejecutar(producto4);
agregarProducto.Ejecutar(producto5);
agregarProducto.Ejecutar(producto9);

listarProductosEnConsola();

Console.WriteLine("\nModificacion de productos");
producto3.PrecioUnitario = 930.50;
producto3.Descripcion = "Balde Pintura Blanca 3.5L"; //las descripciones no podemos cambiarlas porque de ellas depende su hash
producto3.Stock = 8;

producto5.PrecioUnitario = 165.00;
producto5.Stock = 200;

modificarProducto.Ejecutar(producto5);


producto2.PrecioUnitario = -15.22;  // Tipos del elemento modificado inválido
producto2.Stock = -30;         
modificarProducto.Ejecutar(producto2);

modificarProducto.Ejecutar(producto200);  // Modificar un producto que no está agregado

modificarProducto.Ejecutar(producto3);
modificarProducto.Ejecutar(producto3); // Repetido

producto4.Stock = -40;
modificarProducto.Ejecutar(producto4);   // Genera log de exception

producto5.PrecioUnitario = -160.20;     // Genera log de exception
modificarProducto.Ejecutar(producto5);



listarProductosEnConsola();

Console.WriteLine("\nEliminacion de productos");
eliminarProducto.Ejecutar(producto8.Id);


Console.WriteLine("\nListado de productos");
eliminarProducto.Ejecutar(producto200.Id);  //Eliminar un producto que no existe
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

// -------------------- VENTAS ----------------

var repoVenta = new RepositorioSqlite<Venta>();
var agregarVenta = new AgregarVentaUseCase(repoProducto, repoVenta);
var listarVenta = new ListarVentasUseCase(repoVenta);

List<DetalleVenta> detalleVentas = new List<DetalleVenta>();
detalleVentas.Add(new DetalleVenta(32, 5, 999, producto1.Id));
Venta venta = new Venta(detalleVentas);
agregarVenta.Ejecutar(venta);

var lista = listarVenta.Ejecutar();
    foreach (var v in lista)
    {
        Console.WriteLine(v);
    }
    Console.WriteLine("-----");

Console.ReadLine();
