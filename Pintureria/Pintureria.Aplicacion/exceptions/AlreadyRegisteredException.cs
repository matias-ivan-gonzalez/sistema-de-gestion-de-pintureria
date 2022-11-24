public class AlreadyRegisteredException : Exception{
    public AlreadyRegisteredException() : base("La entidad ya fue registrada anteriormente") { }

    public AlreadyRegisteredException(string message) : base(message){ 
    }

    public AlreadyRegisteredException(string message, Exception inner)
    : base(message, inner) { }        
}
