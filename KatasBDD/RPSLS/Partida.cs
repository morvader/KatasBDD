using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPSLS
{
    class Partida
    {
        private Jugador jugador1;
        private Jugador jugador2;

        public Partida(Jugador jugador1, Jugador jugador2)
        {
            // TODO: Complete member initialization
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
        }

        internal string getGanador()
        {
            Opcion opcionJugador1 = jugador1.Opcion;
            Opcion opcionJugador2 = jugador2.Opcion;

            if (opcionJugador1 == opcionJugador2) return "Empate";

            var diferencia = (((opcionJugador2 + 5 - opcionJugador1) % 5) % 2);

            if (diferencia == 0)
                return "Ganas";
            else 
                return "Pierdes";
      
        }
    }
}
