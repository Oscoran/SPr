using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Calculator
    {
        public int Secti(int a, int b)
        {
            return a + b;
        }
        private int Diskriminant (int a, int b, int c)
        {
            return (b*b)-4*a*c;
        }
        public double[] ResKvardRci (int a, int b, int c)
        {
            double[] koreny = new double[2];
            if (Diskriminant (a,b,c)> 0)
            {
                koreny[0] = -b + Math.Sqrt(Diskriminant(a, b, c)) / (2 * a);
                koreny[1] = -b - Math.Sqrt(Diskriminant(a, b, c)) / (2 * a);
                return koreny;
            }
            if (Diskriminant(a, b, c) == 0)
            {
                koreny[0] = -b/ (2 * a);
                
                return koreny;
            }
            else
            {
                koreny = null;
                return koreny;
            }
            
        }
    }
}
