struct Libro
{
    public string Titulo; // Título del libro
    public string Autor;  // Autor del libro
    public int AñoPublicacion; // Año de publicación del libro

    // Método para mostrar información sobre el libro
    public void MostrarInformacion()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Año de Publicación: {AñoPublicacion}");
    }
}

