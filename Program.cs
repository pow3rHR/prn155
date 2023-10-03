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
    }
}
