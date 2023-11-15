namespace prn155;

class Program
{
    static void Main(string[] args)
    {
        // La fuente de datos.
        int[] numeros = new int[10] { 0, 1, 2, 3, 4, 5, 6, 8, 9, 10 };

        // La consulta.
        IEnumerable<int> query =
            from n in numeros
            where (n > 2 && n < 8)
            select n;

        // Ejecución de la consulta
        foreach (int n in query)
        {
            Console.WriteLine(n);
        }


        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante {nombre="Cesar", ID=111, notas= new List<int> {97, 92, 81, 60}},
            new Estudiante {nombre="Iker", ID=112, notas= new List<int> {75, 84, 91, 39}},
            new Estudiante {nombre="Gerson", ID=113, notas= new List<int> {88, 94, 65, 91}},
            new Estudiante {nombre="Darwin", ID=114, notas= new List<int> {97, 89, 85, 82}},
            new Estudiante {nombre="Lisseth", ID=115, notas= new List<int> {35, 72, 91, 70}},
            new Estudiante {nombre="Manuel", ID=116, notas= new List<int> {99, 86, 90, 94}},
            new Estudiante {nombre="Stanley", ID=117, notas= new List<int> {93, 92, 80, 87}},
            new Estudiante {nombre="Sofía", ID=118, notas= new List<int> {25, 72, 80, 87}},
            new Estudiante {nombre="Italo", ID=119, notas= new List<int> {75, 20, 90, 87}},
        };

        IEnumerable<Estudiante> queryEstudiante =
            from e in estudiantes
            where e.notas[0] > 90
            select e;

        foreach(Estudiante e in queryEstudiante) {
            Console.WriteLine(e.nombre);
        }
    }
}
