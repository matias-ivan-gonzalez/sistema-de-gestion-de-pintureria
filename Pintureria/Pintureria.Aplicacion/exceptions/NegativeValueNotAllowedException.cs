public class NegativeValueNotAllowedException : Exception{
    private static string s_mensaje = "{0} no tolera valores negativos";
    public NegativeValueNotAllowedException() : base(String.Format(s_mensaje, "Propiedad")) { }

    public NegativeValueNotAllowedException(string message) : base(String.Format(s_mensaje, message)){ 
    }

    public NegativeValueNotAllowedException(string message, Exception inner)
    : base(message, inner) { }        
}