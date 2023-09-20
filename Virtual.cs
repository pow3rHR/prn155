class Forma {
    public virtual void dibujar() {
        Console.Write("Dibujando forma...");
    }
}

class Circulo : Forma {
    public override void dibujar()
    {
        base.dibujar();
        Console.WriteLine(" Circular.");
    }
}

class Cuadrado : Forma {
    public new void dibujar() {
        Console.WriteLine("Dibujando cuadrado...");
    }
}