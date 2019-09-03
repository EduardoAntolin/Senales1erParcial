using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class EscalonUnitario
    {
        public List<Muestra> muestras { get; set; }

        public EscalonUnitario()
        {
            muestras = new List<Muestra>();
        }
        public double evaluar(double tiempo)
        {
            double resultado;
            if (1 >= tiempo)
            {
                resultado = 1;
            }
            else
            {
                resultado = 0;
            }
            return resultado;
        }
    }
}
