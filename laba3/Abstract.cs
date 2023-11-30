using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    public abstract class Polynomial
    {
        public double a, b, c, x;

        public abstract double Calculate();
    }

    // Нащадок для квадратного багаточлену
    public class QuadraticPolynomial : Polynomial
    {
        public QuadraticPolynomial(double a, double b, double c, double x)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.x = x;
        }

        public override double Calculate()
        {
            return a * x * x + b * x + c;
        }
    }

    // Нащадок для кубічного багаточлену
    public class CubicPolynomial : Polynomial
    {
        private double d;

        public CubicPolynomial(double a, double b, double c, double d, double x)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.x = x;
        }

        public override double Calculate()
        {
            return a * x * x * x + b * x * x + c * x + d;
        }
    }

}
