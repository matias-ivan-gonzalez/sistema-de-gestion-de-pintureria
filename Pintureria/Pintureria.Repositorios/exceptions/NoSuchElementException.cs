public class NoSuchElementException : Exception{
    public NoSuchElementException() : base("Id no registrado") { }

    public NoSuchElementException(string message) : base(message){ 
    }

    public NoSuchElementException(string message, Exception inner)
    : base(message, inner) { }        
}
