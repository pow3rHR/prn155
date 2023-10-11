class CampoDeBatalla {
    private Dictionary<string, List<JugadorPaintBall>> jugadores = new Dictionary<string, List<JugadorPaintBall>>();

    public CampoDeBatalla(List<JugadorPaintBall> equipo1, List<JugadorPaintBall> equipo2) {
        this.jugadores.Add("equipo1", equipo1);
        this.jugadores.Add("equipo2", equipo2);
    }

    public void comenzarBatalla() {

        while (!hayGanador()) {
            
        }
    }
    public bool hayGanador() {
        if (jugadores["equipo1"].Count == 0) {
            return true;
        }
        else if (jugadores["equipo2"].Count == 0) {
            return true;
        }

        return false;
    }

}