using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba3;

namespace UnitTestProject1
{
    [TestClass]
    public class PolynomialTests
    {
        [TestMethod]
        public void QuadraticPolynomial_Calculate()
        {
            QuadraticPolynomial quadraticPolynomial = new QuadraticPolynomial(1, 2, 1, 2);

            double result = quadraticPolynomial.Calculate();

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void CubicPolynomial_Calculate()
        {
            CubicPolynomial cubicPolynomial = new CubicPolynomial(1, 2, 3, 1, 2);

            double result = cubicPolynomial.Calculate();

            Assert.AreEqual(23, result);
        }
    }
}
