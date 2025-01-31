public class ProcesoJugador
{
    private Baraja baraja;
    private List<(string carta, int valor)> cartasJugador;
    private int totalPuntos;
    public ProcesoJugador()
    {
        baraja = new Baraja();
        cartasJugador = new List<(string, int)>();
        totalPuntos = 0;
    }

    public int IniciarJuego()
    {
        Console.WriteLine("\n¡Bienvenido al Blackjack de Omar y Lucas!");
        Console.WriteLine("Aquí tienes tus cartas:");

        // Dar dos cartas iniciales
        DarCarta();
        DarCarta();

        // Menú iterativo
        do
        {
            for (int i = 0; i < cartasJugador.Count; i++)
            {
                Console.WriteLine($"Tu carta es: {cartasJugador[i].carta}, valor: {cartasJugador[i].valor}");
            }
            if (totalPuntos == 21)
            {
                return totalPuntos; // Si el jugador obtiene blackjack, gana automáticamente
            }
            Console.WriteLine($"Total de puntos: {totalPuntos}");
            Console.WriteLine("\n¿Qué deseas hacer? (1) Pedir carta (2) Plantarse");
            string opcion = Console.ReadLine();
            Console.WriteLine();
            if (opcion == "1")
            {
                DarCarta();
                if (totalPuntos > 21)
                {
                    for (int i = 0; i < cartasJugador.Count; i++)
                    {
                        Console.WriteLine($"Tu carta es: {cartasJugador[i].carta}, valor: {cartasJugador[i].valor}");
                    }
                    return totalPuntos;
                }
                else if (totalPuntos == 21)
                {
                    return totalPuntos; // Si el jugador obtiene blackjack, gana automáticamente
                }
            }
            else if (opcion == "2")
            {
                Console.WriteLine($"Te has plantado con {totalPuntos} puntos. Finalizando turno...");
                return totalPuntos;
            }
            else
            {
                Console.WriteLine("\nOpción no válida. Inténtalo de nuevo.");
            }

        } while (totalPuntos < 21);

        // Si se rompe el bucle, igualmente devolvemos el total de puntos
        return totalPuntos;
    }

    private void DarCarta()
    {
        var cartaSeleccionada = baraja.SacarCarta(); // Cogemos la carta que salió en el proceso de sacar carta
        cartasJugador.Add(cartaSeleccionada); // La añadimos a la mano del jugador
        totalPuntos += cartaSeleccionada.valor; // Sumamos su valor al resto de cartas
    }
}