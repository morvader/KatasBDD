using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPSLS
{
    public enum Opcion { Piedra, Papel,Tijeras,Spock, Lagarto};
   
    class Jugador
    {
        public Opcion Opcion {get; set;}

        internal void escogeAuto()
        {
            Random random = new Random();
            this.Opcion = (Opcion)random.Next(0, 4);
            
        }
    }
}
