namespace Pintureria.Repositorios;
using System.Text.RegularExpressions;
using Pintureria.Aplicacion;

public class FileHelper
{
    static string clientesPath = "../Pintureria.Repositorios/recursos/clientes.txt";
    static string productosPath = "../Pintureria.Repositorios/recursos/productos.txt";

    // Metodos genericos para entidades
    void agregarEntidad(string? buscado, Object entidad, string path)
    {
        StreamWriter? streamWriter = null;
        try
        {
            if (buscado == null)
            {
                streamWriter = new StreamWriter(path, true);
                streamWriter.WriteLine($"{entidad.ToString()} ");
            }
            else
            {
                throw new AlreadyRegisteredException();
            }
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            streamWriter?.Close();
        }
    }

    public bool entidadContieneId(string? actual, string id)
    {
        return (actual != null && actual.Contains($"ID: {id}"));
    }

    string? buscarEntidad(string id, string path)
    {
        string? actual = null;
        StreamReader streamReader = new StreamReader(path);
        bool encontrado = false;
        while (!encontrado && !streamReader.EndOfStream)
        {
            actual = streamReader.ReadLine();
            if (entidadContieneId(actual, id))
            {
                encontrado = true;
            }
        }
        streamReader.Close();
        if (encontrado is false) throw new NoSuchElementException();
        return actual;
    }



    List<string> obtenerEntidadesDeArchivoEnLista(string path)
    {
        string? actual = null;
        StreamReader? streamReader = null;
        List<string> clientes = new List<string>();
        try
        {
            streamReader = new StreamReader(path);
            while (!streamReader.EndOfStream)
            {
                actual = streamReader.ReadLine();
                if (actual != null) clientes.Add(actual);
            }

        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            streamReader?.Dispose();
        }
        return clientes;
    }

    void sobreEscribirArchivoConEntidadAlterada(string? archivo, string? actual, string id, string entidad, string path)
    {
        try
        {
            if (actual != null)
            {
                if (entidadContieneId(actual, id))
                {
                    if (actual.Equals(entidad)) throw new ThereIsNoChangesException();
                    archivo = archivo?.Replace(actual, entidad);
                    File.WriteAllText(path, archivo);
                }
                else throw new NoSuchElementException();
            }
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    string? buscarEntidadParaInsercion(string id, string path)
    {
        try
        {
            return buscarEntidad(id, path);
        }
        catch (NoSuchElementException)
        {
            return null;
        }
    }

    void eliminarEntidad(string id, List<string> archivo, string path)
    {
        try
        {
            bool ok = archivo.Remove(archivo.Where(archivo => entidadContieneId(archivo, id)).First());
            if (!ok) throw new NoSuchElementException();
            File.WriteAllLines(path, archivo.ToArray());
        }
        catch
        {

        }
    }

    // <---------------------------------------------------->

    // Metodos para clientes
    public void agregarClienteNoExistente(string? cliente, Cliente cli)
    {
        agregarEntidad(cliente, cli, clientesPath);
    }

    public string? buscarClienteParaInsercion(string id)
    {
        return buscarEntidadParaInsercion(id, clientesPath);
    }

    public void modificarCliente(Cliente cli)
    {
        string? actual = buscarEntidad(cli.Id, clientesPath);
        string? archivo = obtenerArchivoCompleto(clientesPath);
        sobreEscribirArchivoConEntidadAlterada(archivo, actual, cli.Id, cli.ToString(), clientesPath);
    }

    public void removerCliente(string id)
    {
        buscarEntidad(id, clientesPath);
        List<string> archivo = new RepositorioClienteTXT().get();
        eliminarCliente(id, archivo);
    }

    void eliminarCliente(string id, List<string> archivo)
    {
        eliminarEntidad(id, archivo, clientesPath);
    }

    public List<string> getClientes()
    {
        return obtenerEntidadesDeArchivoEnLista(clientesPath);
    }

    // <---------------------------------------------------->

    // Metodos para productos
    public void agregarProductoNoExistente(String? producto, Producto pro)
    {
        agregarEntidad(producto, pro, productosPath);
    }

    public string? buscarProductoParaInsercion(string id)
    {
        return buscarEntidadParaInsercion(id, productosPath);
    }

    public void modificarProducto(Producto pro)
    {
        string? actual = buscarEntidad(pro.Id, productosPath);
        string? archivo = obtenerArchivoCompleto(productosPath);
        sobreEscribirArchivoConEntidadAlterada(archivo, actual, pro.Id, pro.ToString(), productosPath);
    }

    public void removerProducto(string id)
    {
        buscarEntidad(id, productosPath);
        List<string> archivo = new RepositorioProductoTXT().get();
        eliminarProducto(id, archivo);
    }

    void eliminarProducto(string id, List<string> archivo)
    {
        eliminarEntidad(id, archivo, productosPath);
    }

    public List<string> getProductos()
    {
        return obtenerEntidadesDeArchivoEnLista(productosPath);
    }

    public void validarValores(Producto prod)
    {   
        if (prod.Stock < 0) throw new NegativeValueNotAllowedException("Stock"); 
        if (prod.PrecioUnitario < 0) throw new NegativeValueNotAllowedException("Precio unitario");
    }

    // <-------------------------------------------------------------------------------------------------->

    // Operaciones sobre archivos completos

    public string? obtenerArchivoCompleto(string path)
    {
        StreamReader? streamReader = null;
        string? archivo = null;
        try
        {
            streamReader = new StreamReader(path);
            archivo = streamReader.ReadToEnd();
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            streamReader?.DiscardBufferedData();
            streamReader?.BaseStream.Seek(0, SeekOrigin.Begin);
            streamReader?.Dispose();
        }
        return archivo;
    }

    public static int obtenerIdMayor()
    {
        List<string> clientes = new RepositorioClienteTXT().get();
        int id = clientes.Max(c => Regex.Replace(c, "[^0-9]+", string.Empty)[0]);
        return id;
    }

    public static void resetearArchivos()
    {
        try
        {
            File.WriteAllText(clientesPath, "");
            File.WriteAllText(productosPath, "");
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }


    // private void prueba(){
    //     int? uno = null;
    //     Console.WriteLine(uno.ToString);
    //     uno.GetType();
    // }
    // <---------------------------------------------------->
}