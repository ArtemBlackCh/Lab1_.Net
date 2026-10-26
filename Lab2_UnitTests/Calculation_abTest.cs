using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_.Net;

namespace Lab2_UnitTests
{
    [TestClass]
    public class Calculation_abTest
    {
        [TestMethod]
        public void Calculation_a_great_b()
        {
            var calc = new Calculation_ab(2, 1);
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => calc.Count());
        }

        [TestMethod]
        public void Calculation_a_equal_b_matches()
        {
            var calc = new Calculation_ab(232, 232);
            var testRes = 1;
            var res = calc.Count();
            Assert.AreEqual(testRes, res);
        }

        [TestMethod]
        public void Calculation_a_equal_b_not_matches()
        {
            var calc = new Calculation_ab(5, 5);
            var testRes = 0;
            var res = calc.Count();
            Assert.AreEqual(testRes, res);
        }

        [TestMethod]
        public void Calculation_positive_range()
        {
            var calc = new Calculation_ab(0, 1000);
            var testRes = 3;
            var res = calc.Count();
            Assert.AreEqual(testRes, res);
        }

        [TestMethod]
        public void Calculation_negative_range()
        {
            var calc = new Calculation_ab(-100, 0);
            var testRes = 1;
            var res = calc.Count();
            Assert.AreEqual(testRes, res);
        }

        [TestMethod]
        public void Calculation_negative_positive()
        {
            var calc = new Calculation_ab(-1000, 1000);
            var testRes = 7;
            var res = calc.Count();
            Assert.AreEqual(testRes, res);
        }

        [TestMethod]
        public void Calculation_no_numbers_in_range()
        {
            var calc = new Calculation_ab(0, 231);
            var testRes = 0;
            var res = calc.Count();
            Assert.AreEqual(testRes, res);
        }

        [TestMethod]
        public void Calculation_boundaries_are_included()
        {
            var withoutB = new Calculation_ab(233, 521);
            var withB = new Calculation_ab(233, 522);
            var withA = new Calculation_ab(-58, -57);
            Assert.AreEqual(0, withoutB.Count());
            Assert.AreEqual(1, withB.Count());
            Assert.AreEqual(1, withA.Count());
        }

        [TestMethod]
        public void Calculation_max_int_boundary()
        {
            int a = int.MaxValue - 1000;
            var calc = new Calculation_ab(a, int.MaxValue);
            var res = calc.Count();
            int expected = 0;
            for (long i = a; i <= int.MaxValue; i++)
                if (i % 29 == 0 && i % 2 == 0 && i % 5 == 2)
                    expected++;
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Calculation_matches_formula()
        {
            var rnd = new Random(12345);
            for (int t = 0; t < 20; t++)
            {
                int a = rnd.Next(-50000, 50000);
                int b = a + rnd.Next(0, 50000);
                var res = new Calculation_ab(a, b).Count();
                long expected = FloorDiv(b - 232, 290) - FloorDiv(a - 1 - 232, 290);
                Assert.AreEqual((int)expected, res, "a=" + a + ", b=" + b);
            }
        }

        private static long FloorDiv(long x, long m)
        {
            long q = x / m;
            if (x % m != 0 && x < 0)
                q--;
            return q;
        }

        [TestMethod]
        public void Constructor_default_zero_range()
        {
            var calc = new Calculation_ab();
            Assert.AreEqual(0, calc.A);
            Assert.AreEqual(0, calc.B);
            Assert.AreEqual(0, calc.Count());
        }

        [TestMethod]
        public void Constructor_one_parameter_a_is_zero()
        {
            var calc = new Calculation_ab(1000);
            var res = calc.Count();
            Assert.AreEqual(0, calc.A);
            Assert.AreEqual(1000, calc.B);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void Properties_set_and_calculate()
        {
            var calc = new Calculation_ab();
            calc.A = -1000;
            calc.B = 1000;
            Assert.AreEqual(-1000, calc.A);
            Assert.AreEqual(1000, calc.B);
            Assert.AreEqual(7, calc.Count());
        }
    }
}
