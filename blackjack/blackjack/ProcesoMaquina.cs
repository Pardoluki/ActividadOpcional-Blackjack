public class ProcesoMaquina
{

    private Baraja baraja;
    private List<(string carta, int valor)> cartasMaquina;
    private int totalPuntos;

    public ProcesoMaquina()
    {
        baraja = new Baraja();
        cartasMaquina = new List<(string, int)>();
        totalPuntos = 0;
    }

    public int IniciarJuego()
    {
        Console.WriteLine("\nAhora es el turno de la banca. ¡Buena suerte!");
        while (totalPuntos < 17)
        {
            DarCarta();
        }
        for (int i = 0; i < cartasMaquina.Count; i++)
        {
            Console.WriteLine($"La banca ha obtenido: {cartasMaquina[i].carta}, valor: {cartasMaquina[i].valor}");
        }
        return totalPuntos;

    }
    private void DarCarta()
    {
        var cartaSeleccionada = baraja.SacarCarta();
        cartasMaquina.Add(cartaSeleccionada);
        totalPuntos += cartaSeleccionada.valor;
    }
}