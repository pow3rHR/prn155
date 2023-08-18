class Lavadora {
    string nombreMarca = "General ELectric";
    string numeroSerie = "123654";
    int capacidad = 40;
    int potencia = 50;
    bool encendida = false;

    public void encender() {
        this.encendida = true;
    }

    public void apagar() {
        this.encendida = false;
    }

    public void lavar() {
        Console.WriteLine("Estoy lavando...");
    }

}