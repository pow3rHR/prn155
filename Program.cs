namespace prn155;
class Program
{
    enum DiasDeLaSemana
    {
        Lunes,    // 0
        Martes,   // 1
        Miércoles, // 2
        Jueves,   // 3
        Viernes,  // 4
        Sábado,   // 5
        Domingo   // 6
    }

    enum EstadoCivil
    {
        Soltero = 1,
        Casado = 2,
        Divorciado = 3,
        Viudo = 4
    }

    static void Main(string[] args)
    {
        // Acceder a los elementos de la enumeración
        DiasDeLaSemana dia = DiasDeLaSemana.Martes;

        // Mostrar el valor de la enumeración
        Console.WriteLine($"Hoy es: {dia}");

        // Convertir un valor de enumeración a entero
        int valorEntero = (int)dia;
        Console.WriteLine($"Valor entero de Martes: {valorEntero}");

        // Convertir un entero a valor de enumeración
        int numero = 3;
        DiasDeLaSemana dia2 = (DiasDeLaSemana)numero;
        Console.WriteLine($"Número 3 representa: {dia2}");

        //------------------------------------------------------------
        // Asignar un valor de enumeración
        EstadoCivil estado = EstadoCivil.Casado;

        // Mostrar el estado civil
        Console.WriteLine($"Estado civil: {estado}");

        // Convertir un valor de enumeración a cadena
        string estadoComoString = estado.ToString();
        Console.WriteLine($"Estado civil como cadena: {estadoComoString}");

        // Verificar si un valor es parte de la enumeración
        bool esCasado = Enum.IsDefined(typeof(EstadoCivil), "Casado");
        Console.WriteLine($"¿Es 'Casado' un estado civil válido? {esCasado}");
    }
}

