namespace prn155;
class CampoDeBatalla {
    private Dictionary<string, List<JugadorPaintBall>> jugadores = new Dictionary<string, List<JugadorPaintBall>>();
    private List<JugadorPaintBall> eliminados = new List<JugadorPaintBall>();

    public CampoDeBatalla(List<JugadorPaintBall> equipo1, List<JugadorPaintBall> equipo2) {
        this.jugadores.Add("equipo1", equipo1);
        this.jugadores.Add("equipo2", equipo2);
    }

    public void comenzarBatalla() {
        Console.WriteLine("Equipos preparados... comiencen!");
        while (!hayGanador()) {
            foreach (var jugador in this.jugadores.Values)
            {
                foreach (var j in jugador)
                {
                    if (!j.activo) {
                        eliminados.Add(j);
                    }
                    j.correr();
                }
            }

            foreach (var el in eliminados)
            {
                jugadores["equipo1"].Remove(el);
                jugadores["equipo2"].Remove(el);
            }
            
            if(this.jugadores["equipo1"].Count > 0 && this.jugadores["equipo2"].Count > 0) {
                Random rd = new Random();
                int rd1 = rd.Next(0, this.jugadores["equipo1"].Count);
                int rd2 = rd.Next(0, this.jugadores["equipo2"].Count);
            
                this.jugadores["equipo1"].ElementAt(rd1).disparar(this.jugadores["equipo2"].ElementAt(rd2));
                this.jugadores["equipo2"].ElementAt(rd2).disparar(this.jugadores["equipo1"].ElementAt(rd1));

                Console.WriteLine("El juego continuará después de presionar una tecla");
                Console.ReadKey();
            }
        }
    }

    public bool hayGanador() {
        if (jugadores["equipo1"].Count == 0) {
            Console.WriteLine("Ha ganado el equipo 2");
            return true;
        }
        else if (jugadores["equipo2"].Count == 0) {
            Console.WriteLine("Ha ganado el equipo 1");
            return true;
        }

        return false;
    }

}