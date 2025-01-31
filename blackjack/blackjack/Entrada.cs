class Program
{
    public static void Main(string[] args)
    {
        int repetirPartida;
        do
        {
            // Creamos un objeto para manejar el proceso del jugador
            ProcesoJugador procesoJugador = new ProcesoJugador();
            // Creamos un objeto para manejar el proceso de la banca
            ProcesoMaquina procesoMaquina = new ProcesoMaquina();

            // El usuario comienza a jugar hasta pasarse de 21 puntos o plantarse
            int resultadoJugador = procesoJugador.IniciarJuego();

            // Evaluamos el resultado del jugador antes de iniciar la banca
            if (resultadoJugador > 21)
            {
                Console.WriteLine($"Total de puntos: {resultadoJugador}");
                Console.WriteLine("Te has pasado de 21 puntos. Ha ganado la banca. ¡Qué pena!");
            }
            else if (resultadoJugador == 21)
            {
                Console.WriteLine($"Total de puntos: {resultadoJugador}");
                Console.WriteLine("¡Has conseguido un blackjack! Has ganado automáticamente. ¡Enhorabuena!");
            }
            else
            {
                int resultadoMaquina = procesoMaquina.IniciarJuego();
                Console.WriteLine($"Total de puntos: {resultadoMaquina}");

                if (resultadoMaquina > 21)
                {
                    Console.WriteLine("\nLa banca se ha pasado de 21 puntos. ¡Has ganado la partida, felicidades!");
                }
                else if (resultadoMaquina == resultadoJugador)
                {
                    Console.WriteLine("\nEmpate. El dinero de su apuesta le será devuelto");
                }
                else if (resultadoJugador > resultadoMaquina)
                {
                    Console.WriteLine("\nHas conseguido más puntos que la banca. ¡Has ganado la partida, felicidades!");
                }
                else
                {
                    Console.WriteLine("\nHas conseguido menos puntos que la banca. Ha ganado la banca. ¡Qué pena!");
                }
            }
            do
            {
                Console.WriteLine("\n¿Te gustaría volver a jugar una partida?\nSí: Envía 1        No: Envía 2");
                repetirPartida = Convert.ToInt16(Console.ReadLine());
            } while (repetirPartida != 1 && repetirPartida != 2);
        } while (repetirPartida == 1);
        Console.WriteLine("\nGracias por jugar a nuestro blackjack. ¡Vuelva pronto!");
    }
}
