
public class NoSuchElementException : Exception{
    public NoSuchElementException() { }

    public NoSuchElementException(string message) : base($"{message} no registrado"){ 
    }

    public NoSuchElementException(string message, Exception inner)
    : base(message, inner) { }        
}
