# 🃏 Actividad Opcional de Fundamentos de la Programación: Blackjack en C#

Este es un juego de Blackjack en consola desarrollado en C# por los alumnos Omar Alexandre Plana Afonso y Lucas Pardo Parra para la asignatura de Fundamentos de la Programación. Permite jugar como el jugador contra la banca, con lógica para pedir y sacar cartas aleatorias, plantarse y verificar si se ha superado el límite de 21 puntos, así como quién ha resultado ganador en la partida.

## 📂 Estructura del Proyecto

El proyecto está organizado en cuatro archivos principales:

- **`Entrada.cs`**: Contiene el método `Main`, que inicia el juego.
- **`Baraja.cs`**: Genera la baraja de cartas y permite sacar cartas aleatorias sin repetirlas.
- **`ProcesoJugador.cs`**: Controla la lógica del jugador, incluyendo la toma de decisiones y el cálculo del puntaje.
- **`ProcesoMaquina.cs`**: Controla la lógica de la banca, sacando cartas hasta llegar al puntaje mínimo de 17 o sobrepasar los 21 puntos.

## 🎮 Cómo Jugar

1. Al ejecutar el programa, recibirás automáticamente dos cartas.
2. Se te mostrará el total de puntos de tu mano.
3. Aparecerá un menú iterativo que te dará a elegir entre:
   - **Pedir carta** (`1`): Recibes otra carta y se suma su valor.
     - Si te pasas de 21 puntos, pierdes automáticamente.
     - Se vuelve a mostrar el menú para seguir jugando.
   - **Plantarte** (`2`): Terminas tu turno y pasas el control a la banca (pendiente de implementación).
4. El juego termina si os pasáis de 21 tú o, posteriormente, la banca, o designando un ganador comparando el puntaje del usuario y la banca.



## 🚀 ¡Que lo disfrutes!
