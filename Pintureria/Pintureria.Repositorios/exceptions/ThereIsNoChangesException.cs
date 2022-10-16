public class ThereIsNoChangesException : Exception{
    public ThereIsNoChangesException() : base("La modificacion es igual al original") { }

    public ThereIsNoChangesException(string message) : base(message){ 
    }

    public ThereIsNoChangesException(string message, Exception inner)
    : base(message, inner) { }        
}
