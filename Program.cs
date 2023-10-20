namespace prn155;
class Program
{
    static void Main(string[] args)
    {
        string[] mi_cadena = {"Soy", "estudiante", "de", "la", "UES"};

        Console.WriteLine(string.Concat(mi_cadena));
        Console.WriteLine(string.Join(" ", mi_cadena));

        string mi_otra_cadena = "Soy estudiante de la UES y no tiro piedras.";
        
    }
}
