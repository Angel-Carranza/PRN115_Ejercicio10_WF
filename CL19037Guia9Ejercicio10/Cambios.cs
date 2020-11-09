using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL19037Guia9Ejercicio10
{
    class Cambios
    {
        string pokemon;

        public string Pokemon
        {
            get
            {
                return pokemon;
            }

            set
            {
                pokemon = value;
            }
        }

        public string Codificacion()
        {
            string evolucion = null;

            pokemon = pokemon.Trim().ToUpper();

            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    evolucion = pokemon.Replace("A", "1");
                }
                if (i == 1)
                {
                    evolucion = evolucion.Replace("E", "2");
                }
                if (i == 2)
                {
                    evolucion = evolucion.Replace("I", "3");
                }
                if (i == 3)
                {
                    evolucion = evolucion.Replace("O", "4");
                }
                if (i == 4)
                {
                    evolucion = evolucion.Replace("U", "5");
                }
            }
            return evolucion;
        }
    }
}
