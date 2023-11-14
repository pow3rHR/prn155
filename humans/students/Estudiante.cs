namespace students;
using humans;
using helpers;
class Estudiante : Persona, IPuedeHablar {
    public int edad = 25;
    public override void comer() {
        Console.WriteLine("Yum");
    }
    public void hablar() {
        Console.WriteLine("Estoy hablando debilidades");
    }
    public void gritar() {
        Console.WriteLine("Gooooooolll de Messi de penal");
    }
}