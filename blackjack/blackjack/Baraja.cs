public class Baraja
{
    // Creamos listas para los palos y los números de las cartas
    private List<string> palosCartas = new List<string>() { "\u2665", "\u2666", "\u2663", "\u2660" };
    private List<string> numerosCartas = new List<string>() { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

    // Diccionario para almacenar los valores de las cartas en el blackjack
    private Dictionary<string, int> valoresCartas = new Dictionary<string, int>()
    {
        { "A", 11 },  // Para simplificar, diremos que el as siempre vale 11 para poder hacer blackjack
        { "2", 2 },
        { "3", 3 },
        { "4", 4 },
        { "5", 5 },
        { "6", 6 },
        { "7", 7 },
        { "8", 8 },
        { "9", 9 },
        { "10", 10 },
        { "J", 10 },
        { "Q", 10 },
        { "K", 10 }
    };

    // Creamos una lista para juntar palos con números, creando así las cartas
    private List<(string carta, int valor)> barajaCartas = new List<(string, int)>();

    // Constructor para generar la baraja
    public Baraja()
    {
        // Generamos las combinaciones de cartas con sus valores
        foreach (string palo in palosCartas)
        {
            foreach (string numero in numerosCartas)
            {
                int valor = valoresCartas[numero]; // Obtenemos el valor desde el diccionario
                barajaCartas.Add(($"{numero}{palo}", valor));
            }
        }
    }

    // Método para mostrar la baraja con sus valores
    public void MostrarBaraja()
    {
        for (int i = 0; i < barajaCartas.Count; i++)
        {
           Console.WriteLine($"Carta: {barajaCartas[i].carta} - Valor: {barajaCartas[i].valor}");

        }        
    }
}