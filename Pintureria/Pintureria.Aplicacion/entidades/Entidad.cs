public abstract class Entidad {
    public long Id {get; set;}

    protected Entidad(long id){
        Id = id;
    }

    protected Entidad(){}
}
