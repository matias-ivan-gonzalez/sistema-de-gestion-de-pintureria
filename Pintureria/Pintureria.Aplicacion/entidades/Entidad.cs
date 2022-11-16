public abstract class Entidad {
    public long Id {get;protected set;}

    protected Entidad(long id){
        Id = id;
    }

    protected Entidad(){}
}
