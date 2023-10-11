//using System.Collections.ObjectModel;
namespace prn155;
class JugadorPaintBall : Humano {
    public bool activo = true;
    private int balas = 50;
    private int evasividad = 0;

    public JugadorPaintBall(string nombre) {
        this.nombre = nombre;
    }
    public override void correr() {
        this.velocidad += 5;
        
        if (this.velocidad > 1 && this.velocidad <= 5) {
            ++this.evasividad;
        }
        else if (this.velocidad > 5 && this.velocidad <= 10) {
            ++this.evasividad;
        }
        else if (this.velocidad > 10 && this.velocidad <= 15) {
            ++this.evasividad;
        }
        else if (this.velocidad > 25) {
            this.velocidad -= 10;
            --this.evasividad;
        }
    }
    public void disparar(JugadorPaintBall jugador) {
        if (this.balas > 0) {
            this.balas -= 5;

            if (jugador.evasividad == 1) {
                Random rd = new Random();
                int rdi = rd.Next(1, 4);
                if (rdi == 1) {
                    Console.WriteLine($"El jugador {jugador.nombre} lo ha esquivado!");
                }
                else {
                    Console.WriteLine($"El jugador {jugador.nombre} ha recibido un disparo!");
                    jugador.activo = false;
                }
            }
            else if (jugador.evasividad == 2) {
                Random rd = new Random();
                int rdi = rd.Next(1, 4);
                if (rdi == 1 || rdi == 2) {
                    Console.WriteLine($"El jugador {jugador.nombre} lo ha esquivado!");
                }
                else {
                    Console.WriteLine($"El jugador {jugador.nombre} ha recibido un disparo!");
                    jugador.activo = false;
                }
            }
            else if (jugador.evasividad == 3) {
                Random rd = new Random();
                int rdi = rd.Next(1, 4);
                if (rdi == 1 || rdi == 2 || rdi == 3) {
                    Console.WriteLine($"El jugador {jugador.nombre} lo ha esquivado!");
                }
                else {
                    Console.WriteLine($"El jugador {jugador.nombre} ha recibido un disparo!");
                    jugador.activo = false;
                }
            }
        }
        else {
            this.activo = false;
            Console.WriteLine($"Jugador {this.nombre} se queda sin balas, queda eliminado");
        }
    }
}