public class NotEnoughStockToBuyException : Exception{
    private static string s_mensaje = "La cantidad solicitada en la compra supera el stock total del producto";
    public NotEnoughStockToBuyException() : base() { }

    public NotEnoughStockToBuyException(string message) : base(String.Format(s_mensaje, message)){ 
    }

    public NotEnoughStockToBuyException(string message, Exception inner)
    : base(message, inner) { }        
}