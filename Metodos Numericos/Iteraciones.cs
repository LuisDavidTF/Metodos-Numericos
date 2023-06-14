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
        public static double Simpson(double a,double b, double particiones) 
        {
            double i=0,h=0,s=0,s1=0,s2=0,s3=0,x=0;
            if (particiones % 2 != 0) 
                particiones++;
            h = (b - a) / (2.0 * particiones);
            s1 = funcion(a) + funcion(b);
            for (i = 1; i < 2 * particiones; i += 2) 
            {
                s2 += funcion(a + i * h);
            }
            for (i = 2; i < 2 * particiones; i += 2) 
            {
                s3 += funcion(a + i * h);
            }
            s = (h / 3.0) * (s1 + 4.0 * s2 + 2.0 * s3);
            return s;
        }
        public static double funcion(double x) 
        {
            return 4.0 / (1 + x * x);
        }
    }
}
