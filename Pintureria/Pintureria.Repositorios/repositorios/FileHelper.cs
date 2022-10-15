namespace Pintureria.Repositorios;
using Pintureria.Aplicacion;

class FileHelper {
    string clientesPath = "../Pintureria.Repositorios/recursos/clientes.txt";
    string productosPath = "../Pintureria.Repositorios/recursos/productos.txt";

    // Metodos genericos para entidades
    void agregarEntidad(string? cliente, Object entidad){
        StreamWriter? streamWriter = null;
        try{
            if(cliente == null){
                streamWriter = new StreamWriter(clientesPath, true);
                streamWriter.WriteLine($"{entidad.ToString()} ");
            } 
        }
        catch (System.Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            streamWriter?.Close();
        } 
    }

    public bool entidadContieneId(string? actual, int id){
        return (actual !=null && actual.Contains($"ID: {id}"));
    }

    string? buscarEntidad(int id, string path){
        string? actual = null;
        StreamReader streamReader = new StreamReader(path);
        bool encontrado = false;
        while(!encontrado && !streamReader.EndOfStream){
            actual = streamReader.ReadLine();
            if (entidadContieneId(actual, id)){
                encontrado = true;
            }
        }
        streamReader.Close();
        if(encontrado is false) throw new NoSuchElementException("La entidad en cuestion no ha sido registrada");
        return actual;
    }

    public List<string> obtenerEntidadesDeArchivoEnLista(){
        string? actual = null;
        StreamReader? streamReader = null;
        List<string> clientes = new List<string>();
        try{
            streamReader = new StreamReader(clientesPath);
            while(!streamReader.EndOfStream){
                actual = streamReader.ReadLine();
                if(actual != null) clientes.Add(actual);
            }

        }
        catch (System.Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            streamReader?.Dispose();
        }
        return clientes;
    }

    // <---------------------------------------------------->

    // Metodos para clientes
    public void agregarClienteNoExistente(string? cliente, Cliente cli){
        agregarEntidad(cliente, cli);
    }

    public string? buscarClienteParaInsercion(int id){
        try{
            return buscarEntidad(id, clientesPath);
        }
        catch(NoSuchElementException){
            return null;
        }
    }

    public void modificarCliente(Cliente cli){
        string? actual = buscarEntidad(cli.Id, clientesPath);
        string? archivo = obtenerArchivoCompleto();
        sobreEscribirArchivoPorAlteracion(archivo,actual,cli);
    }

    public void removerCliente(int id){
        buscarEntidad(id, clientesPath);        
        List<string> archivo = new RepositorioClienteTXT().get();
        eliminarCliente(id,archivo);
    }

    public void eliminarCliente(int id, List<string> archivo){
        try{
            archivo.Remove(archivo.Where(archivo => entidadContieneId(archivo,id)).First());
            File.WriteAllLines(clientesPath, archivo.ToArray());  
        }
        catch (System.Exception e){
            Console.WriteLine(e.Message);
        }  
    }

    // <---------------------------------------------------->

    // Metodos para productos
    public void agregarProductoNoExistente(String? producto, Producto pro){
        agregarEntidad(producto, pro);
    }

    public string? buscarProductoParaInsercion(int id){
        try{
            return buscarEntidad(id, productosPath);
        }
        catch(NoSuchElementException){
            return null;
        }
    }

    // <---------------------------------------------------->

    // Operaciones sobre archivos completos
    public void sobreEscribirArchivoPorAlteracion(string? archivo, string? actual, Cliente cli){
            try{
                if(actual != null){
                    if (entidadContieneId(actual, cli.Id)){
                        archivo = archivo?.Replace(actual,cli.ToString());
                        File.WriteAllText(clientesPath,archivo);
                    }
                }
            }
            catch (System.Exception e){
                Console.WriteLine(e.Message);
            }
        }
    
    public string? obtenerArchivoCompleto(){
        StreamReader? streamReader = null;
        string? archivo = null;
        try{
            streamReader = new StreamReader(clientesPath);
            archivo = streamReader.ReadToEnd();
        }
        catch (System.Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            streamReader?.DiscardBufferedData();
            streamReader?.BaseStream.Seek(0, SeekOrigin.Begin);
            streamReader?.Dispose();
        }
        return archivo;
    }

    // <---------------------------------------------------->
}