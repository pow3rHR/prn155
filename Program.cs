using System.Runtime.CompilerServices;

namespace prn155;
class Program
{
    static void Main(string[] args)
    {
        TestArrayList al = new TestArrayList();
        al.estudiantes.Add("Diego");
        al.estudiantes.Add(20);
        al.estudiantes.Add(true);

        foreach (var item in al.estudiantes)
        {
            Console.WriteLine(item);
        }

        al.estudiantes.Remove(20);

        Console.WriteLine(al.estudiantes.Count);

        TestList ls = new TestList();
        ls.numerosNaturales.Add(1);
        ls.numerosNaturales.Add(2);
        ls.numerosNaturales.AddRange(ls.numerosNaturales);

        foreach (int item in ls.numerosNaturales)
        {
            Console.WriteLine(item);
        }

        TestDictionary dt = new TestDictionary();
        dt.personas.Add("nombre", "Diego");
        dt.personas.Add("Apellido", "Herrera");
        dt.personas.Add("edad", "20");

        Console.WriteLine("Mi nombre es: " + dt.personas["nombre"] + "y tengo " + dt.personas["edad"] + " anios");

        foreach (var item in dt.personas)
        {
            Console.WriteLine(item);
        }
    }
}
