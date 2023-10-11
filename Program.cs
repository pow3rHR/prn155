namespace prn155;
class Program
{
    static void Main(string[] args)
    {
        List<JugadorPaintBall> equipo1 = new List<JugadorPaintBall>();
        List<JugadorPaintBall> equipo2 = new List<JugadorPaintBall>();

        JugadorPaintBall e11 = new JugadorPaintBall("e11");
        JugadorPaintBall e12 = new JugadorPaintBall("e12");
        JugadorPaintBall e13 = new JugadorPaintBall("e13");
        JugadorPaintBall e21 = new JugadorPaintBall("e21");
        JugadorPaintBall e22 = new JugadorPaintBall("e22");
        JugadorPaintBall e23 = new JugadorPaintBall("e23");

        equipo1.Add(e11);
        equipo1.Add(e12);
        equipo1.Add(e13);

        equipo2.Add(e21);
        equipo2.Add(e22);
        equipo2.Add(e23);

        CampoDeBatalla cb = new CampoDeBatalla(equipo1, equipo2);

        cb.comenzarBatalla();
    }
}
