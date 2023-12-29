using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int x, int y)
        {
            return x + y;
        }
        public int Subtrair(int x, int y)
        {
            return x - y;
        }
        public int Multiplicar(int x, int y)
        {
            return x * y;
        }
        public int Dividir(int x, int y)
        {
            return x / y;
        }
    }
}
