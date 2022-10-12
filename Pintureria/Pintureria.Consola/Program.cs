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
var lista = listarClientes.Ejecutar();
foreach (var c in lista)
{
Console.WriteLine(c);
}
Console.WriteLine("-----");
}