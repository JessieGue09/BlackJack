using System;

namespace BlackJack
{
    class Program
    {
        static void CartasJugador()
        {
            int cartasjugador = 1;

            if(cartasjugador == 0)
            {
                Console.WriteLine("El número de cartas que tienes es: "+ cartasjugador);
            } else {
                Console.WriteLine("El número de cartas que tienes es: "+ cartasjugador, "Deseas agregar otra?");
            }
        }
        static void PrimerJuego()
        {
            Console.WriteLine("¡Bienvenido!, has comenzado con 0 cartas.");

        }
        static void Main(string[] args)
        {
            PrimerJuego();
            CartasJugador();
        }
    }
}
