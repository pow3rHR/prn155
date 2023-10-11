namespace prn155;
abstract class Humano {
    public string nombre;
    protected uint edad;
    protected uint velocidad = 0;

    public abstract void correr();
}