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
        Console.WriteLine("¡Bienvenido al Blackjack de Omar y Lucas!");
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
                    Console.WriteLine($"Total de puntos: {totalPuntos}");
                    Console.WriteLine("\nTe has pasado de 21. ¡Has perdido!");
                    return totalPuntos;
                }
                else if (totalPuntos == 21)
                {
                    Console.WriteLine("\n¡Has alcanzado 21! Finalizando turno...");
                    return totalPuntos;
                }
            }
            else if (opcion == "2")
            {
                Console.WriteLine($"\nTe has plantado con {totalPuntos} puntos.");
                return totalPuntos;
            }
            else
            {
                Console.WriteLine("\nOpción no válida. Inténtalo de nuevo.");
            }

        } while (totalPuntos < 21);

        // Si el bucle se rompe, devolver el total de puntos como seguridad.
        return totalPuntos;
    }


    private void DarCarta()
    {
        var cartaSeleccionada = baraja.SacarCarta(); // Cogemos la carta que salió en el proceso de sacar carta
        cartasJugador.Add(cartaSeleccionada); // La añadimos a la mano del jugador
        totalPuntos += cartaSeleccionada.valor; // Sumamos su valor al resto de cartas
    }
}