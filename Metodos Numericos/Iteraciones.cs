using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Numericos
{
    class Iteraciones
    {
        public double iteracionX1(double x1, double x2, double x3) 
        {
            double valX1 = (20-(3*x3))/8;

            return valX1;
        }
        public double iteracionX2(double x1, double x2, double x3)
        {
            double valX2 = (5-(2*x1)-(x3))/6;
            
            return valX2;
        }
        public double iteracionX3(double x1, double x2, double x3)
        {
            return (10-(2*x2))/3;
        }
    }
}
