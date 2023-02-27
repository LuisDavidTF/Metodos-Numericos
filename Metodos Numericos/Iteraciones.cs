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
            //x1+2x2+x3=8
            //2x1+2x2+3x3=9
            //3x1+    4x3=2

            double valX1 = 8 - (2 * x2) - x3;

            return valX1;
        }
        public double iteracionX2(double x1, double x2, double x3)
        {
            //x1+2x2+x3=8
            //2x1+2x2+3x3=9
            //3x1+    4x3=2

            
            double valX2 = (9 - (2 * x1) - (3 * x3)) / 2;

            return valX2;
        }
        public double iteracionX3(double x1, double x2, double x3)
        {
            //x1+2x2+x3=8
            //2x1+2x2+3x3=9
            //3x1+    4x3=2


            return (2 - (3 * x1)) / 4;
        }
    }
}
