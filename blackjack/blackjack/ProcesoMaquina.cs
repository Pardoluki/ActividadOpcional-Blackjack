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
        Console.WriteLine("Ahora es el turno de la banca");
        while (totalPuntos < 17)
        {
            for (int i = 0; i < cartasMaquina.Count; i++)
            {
                Console.WriteLine($"Tu carta es: {cartasMaquina[i].carta}, valor: {cartasMaquina[i].valor}");
            }
            Console.WriteLine($"Total de puntos: {totalPuntos}");
            DarCarta();
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