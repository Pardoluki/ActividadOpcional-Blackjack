using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        // Creamos un objeto para manejar el proceso del jugador
        ProcesoJugador procesoJugador = new ProcesoJugador();

        // El usuario comienza a jugar hasta pasarse de 21 puntos o plantarse
        procesoJugador.IniciarJuego();
    }
}