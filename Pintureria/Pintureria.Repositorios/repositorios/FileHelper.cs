using Pintureria.Aplicacion;
class FileHelper{
    string path = "../Pintureria.Repositorios/recursos/clientes.txt";

    public void sobreEscribirArchivoPorAlteracion(string? archivo, string? actual, Cliente cli){
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

    public void agregarClienteNoExistente(string? cliente, Cliente cli){
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

    public bool clienteContieneId(string? actual, int id){
        return (actual !=null && actual.Contains($"ID: {id}"));
    }

    public string? obtenerArchivoCompleto(){
        StreamReader? streamReader = null;
        string? archivo = null;
        try{
            streamReader = new StreamReader(path);
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

    public string? buscarClienteParaInsercion(int id){
        try{
            return buscarCliente(id);
        }
        catch(NoSuchElementException){
            return null;
        }
        
    }

    public string? buscarCliente(int id){
        string? actual = null;
        StreamReader streamReader = new StreamReader(path);
        bool encontrado = false;
        while(!encontrado && !streamReader.EndOfStream){
            actual = streamReader.ReadLine();
            if (clienteContieneId(actual, id)){
                encontrado = true;
            }
        }
        streamReader.Close();
        if(encontrado is false) throw new NoSuchElementException("La entidad en cuestion no ha sido registrada");
        return actual;
    }

    public void eliminarCliente(int id, List<string> archivo){
        try{
            archivo.Remove(archivo.Where(archivo => clienteContieneId(archivo,id)).First());
            File.WriteAllLines(path, archivo.ToArray());  
        }
        catch (System.Exception e){
            Console.WriteLine(e.Message);
        }
        
    }

    public List<string> obtenerEntidadesDeArchivoEnLista(){
        string? actual = null;
        StreamReader? streamReader = null;
        List<string> clientes = new List<string>();
        try{
            streamReader = new StreamReader(path);
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
}