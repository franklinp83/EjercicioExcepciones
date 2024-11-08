using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones
{
    public class Operaciones
    {
        public double Sumar(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Restar(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }
        public double Dividir(double n1, double n2)
        {
            if (n2 == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
            return n1 / n2;
        }
    }
}
