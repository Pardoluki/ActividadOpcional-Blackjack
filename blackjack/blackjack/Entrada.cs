class Program
{
    public static void Main(string[] args)
    {
        // Creamos un objeto para manejar el proceso del jugador
        ProcesoJugador procesoJugador = new ProcesoJugador();

        // El usuario comienza a jugar hasta pasarse de 21 puntos o plantarse
        int resultadoJugador = procesoJugador.IniciarJuego();
        Console.WriteLine($"Resultado Jugador: {resultadoJugador}");

        ProcesoMaquina procesoMaquina = new ProcesoMaquina();

        // Evaluar resultado del jugador antes de iniciar la banca
        if (resultadoJugador > 21)
        {
            Console.WriteLine("Te has pasado de 21 puntos. Ha ganado la banca.");
        }
        else
        {
            int resultadoMaquina = procesoMaquina.IniciarJuego();
            Console.WriteLine($"Resultado Máquina: {resultadoMaquina}");

            if (resultadoMaquina > 21)
            {
                Console.WriteLine("La banca se ha pasado de 21 puntos. ¡Has ganado la partida, felicidades!");
            }
            else if (resultadoMaquina == resultadoJugador)
            {
                Console.WriteLine("Empate. La banca gana por reglas del casino.");
            }
            else if (resultadoJugador > resultadoMaquina)
            {
                Console.WriteLine("¡Has ganado la partida, felicidades!");
            }
            else
            {
                Console.WriteLine("Ha ganado la banca.");
            }
        }
    }
}
