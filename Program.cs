using System;

namespace BlackJack
{
    class Program
    {
        /// <summary>
        /// Le damos la bienvenida al jugador y mostramos que comienza con 0 cartas.
        /// </summary>
        static void PrimerJuego()
        {
            // Mostrar al jugar con cuantas cartas comienza
            Console.WriteLine("¡Bienvenido!, has comenzado con 0 cartas.");

        }

        /// <summary>
        /// Preguntar al usuario si desea un carta.
        /// </summary>
        /// <returns>La decision tomada: Y - Desea cartas, N - no desea cartas</returns>
        static string SolicitarCartas()
        {
            // Y: Yes
            // N: No
            Console.WriteLine("¿Deseas tomar una carta?");
            Console.WriteLine("Y = Deseo una carta");
            Console.WriteLine("N = No deseo una carta");

             string option = Convert.ToString(Console.ReadLine());
             return option;
        }

        static void Main(string[] args)
        {
           // TODO: El jugador comienza con un manojo de cartas vacio
            PrimerJuego();

            // TODO: Preguntar al jugar si desea quedarse con las cartas que tiene, o si solicita una carta.
            string option = SolicitarCartas();
            Console.WriteLine("Opción seleccionada: " + option);


            //CartasJugador();
        }
    }
}
