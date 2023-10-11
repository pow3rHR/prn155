namespace prn155;
class Program
{
    static void Main(string[] args)
    {
        // Crear un punto usando el constructor del struct
        Punto miPunto = new Punto(3, 5);

        // Acceder a las coordenadas del punto
        Console.WriteLine($"Coordenadas del punto: ({miPunto.X}, {miPunto.Y})");

        // Crear un libro usando el struct
        Libro miLibro = new Libro
        {
            Titulo = "El Código Da Vinci",
            Autor = "Dan Brown",
            AñoPublicacion = 2003
        };

        // Llamar al método para mostrar la información del libro
        miLibro.MostrarInformacion();
    }
}
