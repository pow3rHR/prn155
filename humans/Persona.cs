namespace humans;
using helpers;

abstract class Persona {

    public abstract void comer();

}

class Estudiante : Persona, IPuedeHablar {
    public override void comer() {
        Console.WriteLine("Yum");
    }
}