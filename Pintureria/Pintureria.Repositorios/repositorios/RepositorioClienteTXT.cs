using System.Text.RegularExpressions;
namespace Pintureria.Repositorios;
using Pintureria.Aplicacion;
public class RepositorioClienteTXT : IRepositorioCliente {
    string path = "../Pintureria.Repositorios/recursos/clientes.txt";

    public RepositorioClienteTXT(){}
    public void add(Cliente cli){
        string? cliente = buscarCliente(cli.Id);
        agregarClienteNoExistente(cliente, cli);
    }
    public void modify(Cliente cli){
        try{
            string? archivo = obtenerArchivoCompleto();
            string? actual = buscarCliente(cli.Id);
            sobreEscribirArchivoPorAlteracion(archivo,actual,cli);
        }
        catch (System.Exception e){
            Console.WriteLine(e.Message);
        }
    }
    public void delete(int id){
        try{
            string? cliente = buscarCliente(id);
            if(cliente != null){
                List<string> archivo = get();
                archivo.Remove(archivo.Where(archivo => clienteContieneId(archivo,id)).First());
                File.WriteAllLines(path, archivo.ToArray());
            }
        }
        catch (System.Exception e){
            Console.WriteLine(e.Message);
        }
    }
    public List<string> get(){
        string? actual = null;
        StreamReader? streamReader = new StreamReader(path);
        List<string?> clientes = new List<string?>();
        try{
            while(!streamReader.EndOfStream){
                actual = streamReader.ReadLine();
                clientes.Add(actual);
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

    void sobreEscribirArchivoPorAlteracion(string? archivo, string? actual, Cliente cli){
        try{
            if(actual != null){
                if (clienteContieneId(actual, cli.Id)){
                    archivo = archivo?.Replace(actual,cli.ToString());
                    File.WriteAllText(path,archivo);
                }
            }
        }
        catch (System.Exception e){
            Console.WriteLine(e.Message);
        }
    }

    void agregarClienteNoExistente(string? cliente, Cliente cli){
        StreamWriter? streamWriter = null;
        try{
            if(cliente == null){
                streamWriter = new StreamWriter(path, true);
                streamWriter.WriteLine($"{cli.ToString()} ");
            } 
        }
        catch (System.Exception e){
             Console.WriteLine(e.Message);
        }
        finally{
            streamWriter?.Close();
        }
        
    }

    bool clienteContieneId(string? actual, int id){
        return (actual !=null && actual.Contains($"ID: {id}"));
    }

    string? obtenerArchivoCompleto(){
        StreamReader? streamReader = null;
        string? archivo = null;
        try{
            streamReader = new StreamReader(path);
            archivo = streamReader.ReadToEnd();
        }
        catch (System.Exception){
            
        }
        finally{
            streamReader?.DiscardBufferedData();
            streamReader?.BaseStream.Seek(0, SeekOrigin.Begin);
            streamReader?.Dispose();
        }
        return archivo;
    }

    string? buscarCliente(int id){
        string? actual = null;
        try{
            StreamReader streamReader = new StreamReader(path);
            bool encontrado = false;
            while(!encontrado && !streamReader.EndOfStream){
                    actual = streamReader.ReadLine();
                    if (clienteContieneId(actual, id)){
                        encontrado = true;
                    }
                }
            streamReader.Close();
            if(encontrado){
                return actual;
            }
        }
        catch (System.Exception e){
            Console.WriteLine(e.Message);
        }
        return null;
    }
}
