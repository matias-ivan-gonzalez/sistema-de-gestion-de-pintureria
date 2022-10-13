using System.Text.RegularExpressions;
namespace Pintureria.Repositorios;
using Pintureria.Aplicacion;
public class RepositorioClienteTXT : IRepositorioCliente {
    string path = "../Pintureria.Repositorios/recursos/clientes.txt";

    public RepositorioClienteTXT(){}
    public bool add(Cliente cli){
        StreamWriter? streamWriter = null;
        try{
            string? cliente = buscarCliente(cli.Id);
            if(cliente == null){
                streamWriter = new StreamWriter(path, true);
                streamWriter.WriteLine($"{cli.ToString()} ");
                return true;
            }
        }
        catch (System.Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            streamWriter?.Dispose();
        }
        return false;
    }
    public bool modify(Cliente cli){
        try{
            string? archivo = obtenerArchivoCompleto();
            string? actual = buscarCliente(cli.Id);
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
        return false;
    }
    public bool delete(int id){
        return false;
    }
    public bool get(){
        return false;
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
