class Perro
{
    string nombre;
    string color;
    int edad;

    public Perro(string nombre, string color, int edad) {
        this.nombre = nombre;
        this.color = color;
        this.edad = edad;
    }
    public void ladrar() {
        Console.WriteLine("Guau guau");
    }

    public void mostrarInfo() {
        Console.WriteLine("Nombre: " + this.nombre + " Edad: " + this.edad);
    }
}