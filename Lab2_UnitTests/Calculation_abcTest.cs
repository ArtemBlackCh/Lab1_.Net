using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_.Net;

namespace Lab2_UnitTests
{
    [TestClass]
    public class Calculation_abcTest
    {
        private const double Delta = 1e-9;

        [TestMethod]
        public void Calculation_positive_positive_positive()
        {
            var calc = new Calculation_abc(1, 2, 3);
            var testRes = 36;
            var res = calc.Calculate();
            Assert.AreEqual(testRes, res, Delta);
        }

        [TestMethod]
        public void Calculation_positive_negative_negative()
        {
            var calc = new Calculation_abc(5, -1, -2);
            var testRes = 4;
            var res = calc.Calculate();
            Assert.AreEqual(testRes, res, Delta);
        }

        [TestMethod]
        public void Calculation_negative_negative_positive()
        {
            var calc = new Calculation_abc(-4, -2, 3);
            var testRes = 9;
            var res = calc.Calculate();
            Assert.AreEqual(testRes, res, Delta);
        }

        [TestMethod]
        public void Calculation_negative_negative_negative()
        {
            var calc = new Calculation_abc(-1, -2, -3);
            var testRes = 14;
            var res = calc.Calculate();
            Assert.AreEqual(testRes, res, Delta);
        }

        [TestMethod]
        public void Calculation_zero_negative_negative()
        {
            var calc = new Calculation_abc(0, -1, -2);
            var testRes = 5;
            var res = calc.Calculate();
            Assert.AreEqual(testRes, res, Delta);
        }

        [TestMethod]
        public void Calculation_zero_zero_zero()
        {
            var calc = new Calculation_abc(0, 0, 0);
            var testRes = 0;
            var res = calc.Calculate();
            Assert.AreEqual(testRes, res, Delta);
        }

        [TestMethod]
        public void Calculation_fractional_numbers()
        {
            var calc = new Calculation_abc(0.5, -1.5, -2.0);
            var testRes = 9;
            var res = calc.Calculate();
            Assert.AreEqual(testRes, res, Delta);
        }

        [TestMethod]
        public void Constructor_default_all_zero()
        {
            var calc = new Calculation_abc();
            Assert.AreEqual(0, calc.A, Delta);
            Assert.AreEqual(0, calc.B, Delta);
            Assert.AreEqual(0, calc.C, Delta);
            Assert.AreEqual(0, calc.Calculate(), Delta);
        }

        [TestMethod]
        public void Constructor_two_parameters_c_is_zero()
        {
            var calc = new Calculation_abc(3, -1);
            var res = calc.Calculate();
            Assert.AreEqual(3, calc.A, Delta);
            Assert.AreEqual(-1, calc.B, Delta);
            Assert.AreEqual(0, calc.C, Delta);
            Assert.AreEqual(4, res, Delta);
        }

        [TestMethod]
        public void Properties_set_and_calculate()
        {
            var calc = new Calculation_abc();
            calc.A = 2;
            calc.B = 3;
            calc.C = 4;
            Assert.AreEqual(2, calc.A, Delta);
            Assert.AreEqual(3, calc.B, Delta);
            Assert.AreEqual(4, calc.C, Delta);
            Assert.AreEqual(81, calc.Calculate(), Delta);
        }

        [TestMethod]
        public void Constructor_nan_throws()
        {
            Assert.ThrowsExactly<ArgumentException>(() => new Calculation_abc(1, double.NaN, 3));
        }

        [TestMethod]
        public void Property_infinity_throws()
        {
            var calc = new Calculation_abc(1, 2, 3);
            Assert.ThrowsExactly<ArgumentException>(() => calc.C = double.PositiveInfinity);
        }
    }
}
