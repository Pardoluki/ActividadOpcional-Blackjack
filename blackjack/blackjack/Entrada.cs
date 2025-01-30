using System.Collections;

class Program
{
    public static void Main (string[]args){
        Baraja baraja = new Baraja();
        baraja.MostrarBaraja();
    }
}

// 1. Crear baraja con Array
// 2. Crear proceso
//      - Bienvenida y pedir apuesta (será devuelta multiplicada x2 si se gana)
//      - Dar dos cartas al jugador automáticamente
//      - Sumar valor
//      - Menú iterativo (pedir carta o plantarse)
//              - Pedir carta: dar carta
//              - Sumar valor
//                    - Si se pasa de 21: has perdido
//              - menú iterativo
//
//              - Plantarse: continuar
//      - La banca empieza a jugar sola (saca cartas automáticamente)
//      - Si llega a 17 o se pasa de 21, se termina el juego y se determina el ganador